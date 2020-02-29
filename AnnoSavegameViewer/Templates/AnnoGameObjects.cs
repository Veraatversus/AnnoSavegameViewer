using AnnoSavegameViewer.Structures.Savegame;
using AnnoSavegameViewer.Structures.Savegame.Generated;
using System.Collections.Generic;
using System.Linq;

namespace AnnoSavegameViewer.Templates {

  public class AnnoGameObjects {

    #region Public Properties

    public HashSet<AnnoItem> Items { get; } = new HashSet<AnnoItem>();
    public HashSet<AnnoItem> Upgrades { get; } = new HashSet<AnnoItem>();
    public HashSet<AnnoItem> GameObjects { get; } = new HashSet<AnnoItem>();

    #endregion Public Properties

    #region Public Constructors

    public AnnoGameObjects(DataBaseNode baseNode) {
      foreach (var session in baseNode.MetaGameManager.GameSessions.GameSessionsList) {
        //Participants
        var Participants = session
          .SessionData
          .BinaryData
          .GameSessionManager
          .SessionParticipantManager
          .ParticipantIDToObjects
          .ParticipantIDToObjectsList
          .ToDictionary(p => p.Value.Id, p => new AnnoParticipant(p.Value.Id));

        //Find Participants Objects
        var participantsObjects = session
          .SessionData
          .BinaryData
          .GameSessionManager
          .AreaManager[0]
          .AreaObjectManager
          .GameObject
          .Objects
          .GameObjectsList
          .Where(o => o.Profile is Profile _)
          .Take(Participants.Count);

        foreach (var participant in participantsObjects) {
          Participants[participant.ParticipantID.Id].GUID = participant.Guid;
        }

        //AreaInfos
        var AreaInfos = session
         .SessionData
         .BinaryData
         .GameSessionManager
         .AreaInfo
         .Ids
         .Zip(session.SessionData.BinaryData.GameSessionManager.AreaInfo.AreaInfoList)
         .ToDictionary(x => x.First, x => x.Second);

        //AreaManager
        foreach (var areaManager in session.SessionData.BinaryData.GameSessionManager.AreaManager) {
          AreaInfos.TryGetValue(areaManager.AreaItemManager.AreaSlotContainer.AreaID, out var areaInfo);
          if (areaInfo != null) {
            foreach (var kontorItem in areaManager.AreaItemManager.AreaSlotContainer.SlotList.AreaSlotContainerSlotListList ?? Enumerable.Empty<AreaSlotContainerSlotListList>()) {
              foreach (var item in kontorItem.Stack.AreaSlotContainerSlotListListStackList ?? Enumerable.Empty<AreaSlotContainerSlotListListStackList>()) {
                if (item.GUID?.GUID != null) {
                  Items.Add(new AnnoItem {
                    GUID = item.GUID,
                    Amount = 1,
                    InUse = false,
                    Participant = Participants[areaInfo.Owner.id],
                    AreaManager = areaManager,
                    AreaInfo = areaInfo,
                    Session = session
                  });
                }
              }
            }
          }
          //GameObjects
          foreach (var gameObject in areaManager.AreaObjectManager.GameObject.Objects?.GameObjectsList ?? Enumerable.Empty<GameObjectObjectsList>()) {
            var participant = Participants[gameObject.ParticipantID.Id];

            if ((gameObject.ShipMaintenance != null || (gameObject.Building != null && ProgrammSettings.Texts.ContainsKey(gameObject.Guid.GUID))) /*&& participant.GUID.GUID != 34*/) {
              GameObjects.Add(new AnnoItem {
                GUID = gameObject.Guid,
                Participant = participant,
                ParentObject = gameObject,
                AreaManager = areaManager,
                AreaInfo = areaInfo,
                Session = session,
                Amount = 1
              });

              foreach (var slotItem in gameObject.ItemContainer?.SlotContainer?.SlotList?.SlotContainerSlotListList ?? Enumerable.Empty<SlotContainerSlotListList>()) {
                if (slotItem?.Stack?.StackList?.GUID != null) {
                  Items.Add(new AnnoItem {
                    GUID = slotItem.Stack.StackList.GUID,
                    Amount = slotItem.ProductStackSize,
                    InUse = false,
                    Participant = participant,
                    ParentObject = gameObject,
                    AreaManager = areaManager,
                    AreaInfo = areaInfo,
                    Session = session
                  });
                }
              }

              foreach (var socketItem in gameObject.ItemContainer?.SocketContainer?.SocketItems?.SocketItemsList ?? Enumerable.Empty<SocketItemsList>()) {
                if (socketItem.GUID != null) {
                  Items.Add(new AnnoItem {
                    GUID = socketItem.GUID,
                    Amount = 1,
                    InUse = true,
                    Participant = participant,
                    ParentObject = gameObject,
                    AreaManager = areaManager,
                    AreaInfo = areaInfo,
                    Session = session
                  });
                }
              }

              if (gameObject.UpgradeList != null) {
                foreach (var upgrade in gameObject.UpgradeList.UpgradeGUIDs.GUIDs ?? Enumerable.Empty<DescriptionInt>()) {
                  Upgrades.Add(new AnnoItem {
                    GUID = upgrade,
                    Amount = 1,
                    InUse = true,
                    Participant = participant,
                    ParentObject = gameObject,
                    AreaManager = areaManager,
                    AreaInfo = areaInfo,
                    Session = session
                  });
                }

                //Maybe  Data Classes Incomplete
                //foreach (var upgrade in gameObject.UpgradeList.UpgradeSets) {
                //}
              }
            }
          }
        }
      }
    }

    #endregion Public Constructors
  }
}

//var allItems = session.SessionData.BinaryData.GameSessionManager.AreaManager
//  //.GroupBy(am => am.AreaItemManager.AreaSlotContainer.AreaID,)
//  .Where(am => AreaInfos.ContainsKey(am.AreaItemManager.AreaSlotContainer.AreaID))
//  .Select(am => (areaInfo: AreaInfos[am.AreaItemManager.AreaSlotContainer.AreaID], areaManager: am))
//  .SelectMany(am => am.areaManager.AreaObjectManager.GameObject.Objects?.GameObjectsList ?? Enumerable.Empty<GameObjectObjectsList>(),
//     (areaManager, objects) => (areaData: areaManager, gameObject: objects))
//  .SelectMany(adgo => (adgo.gameObject.ItemContainer?.SlotContainer?.SlotList?.SlotContainerSlotListList?
//    .Select(si => new AnnoItem { Amount = si.ProductStackSize, GUID = si.Stack.StackList.GUID, InUse = false }) ?? Enumerable.Empty<AnnoItem>())
//    .Concat(adgo.gameObject.ItemContainer?.SocketContainer?.SocketItems?.SocketItemsList?
//      .Select(si => new AnnoItem { GUID = si.GUID, Amount = 1, InUse = true }) ?? Enumerable.Empty<AnnoItem>())
//    .Where(i => i?.GUID != null),
//      (adgo, item) => (AreaDataGameObject: adgo, Item: item));
//.ToLookup(iadgo => iadgo.Item.GUID, new DescriptionIntComparer());
//.ToLookup(iadgo => Participants[iadgo.AreaDataGameObject.areaData.areaInfo.Owner.id].GUID, new DescriptionIntComparer());

//.SelectMany(am=> am.AreaObjectManager.GameObject.Objects?.GameObjectObjectsList ?? Enumerable.Empty<GameObjectObjectsList>())

// var Gebäudeproinselporplayer = session.SessionData.BinaryData.GameSessionManager.AreaManager
// .GroupBy(am => am.AreaItemManager.AreaSlotContainer.AreaID) .Where(am =>
// AreaInfos.ContainsKey(am.Key)) .Select(am => (AremInfo: AreaInfos[am.Key], objects: am
// .SelectMany(am => am.AreaObjectManager.GameObject.Objects?.GameObjectsList ??
// Enumerable.Empty<GameObjectObjectsList>()) .Where(o => Participants[o.ParticipantID.Id].GUID.GUID
// != 34 && (o.ShipMaintenance != null || (o.Building != null &&
// ProgrammSettings.Texts.ContainsKey(o.Guid.GUID))) &&
// (o.ItemContainer?.SlotContainer?.SlotList?.SlotContainerSlotListList != null ||
// o.ItemContainer?.SocketContainer?.SocketItems?.SocketItemsList != null)) .SelectMany(o =>
// (o.ItemContainer?.SlotContainer?.SlotList?.SlotContainerSlotListList? .Select(si => new AnnoItem
// { Amount = si.ProductStackSize, GUID = si.Stack.StackList.GUID, InUse = false }) ??
// Enumerable.Empty<AnnoItem>())
// .Concat(o.ItemContainer?.SocketContainer?.SocketItems?.SocketItemsList? .Select(si => new
// AnnoItem { GUID = si.GUID, Amount = 1, InUse = true }) ?? Enumerable.Empty<AnnoItem>()) .Where(i
// => i?.GUID != null), (go, item) => (go, item)) .ToLookup(e => e.go, new GameObjectComparer())))
// .Where(ao => ao.objects.Any()) .ToLookup(amo => Participants[amo.AremInfo.Owner.id].GUID, new DescriptionComparer());

// //Gebäunde Only var ParticipantsObjects =
// session.SessionData.BinaryData.GameSessionManager.AreaManager .GroupBy(am =>
// am.AreaItemManager.AreaSlotContainer.AreaID) .Where(am => AreaInfos.ContainsKey(am.Key))
// .Select(am => (
// AremInfo: AreaInfos[am.Key],
// objects: am .SelectMany(am => am.AreaObjectManager.GameObject.Objects?.GameObjectsList ??
// Enumerable.Empty<GameObjectObjectsList>()) .Where(o => Participants[o.ParticipantID.Id].GUID.GUID
// != 34 && (o.ShipMaintenance != null || (o.Building != null &&
// ProgrammSettings.Texts.ContainsKey(o.Guid.GUID)))) .ToLookup(ao => ao.Guid, new
// DescriptionComparer()))) .Where(ao => ao.objects.Any()) .ToLookup(amo =>
// Participants[amo.AremInfo.Owner.id].GUID, new DescriptionComparer());

// //var ParticipantsObjects = session.SessionData.BinaryData.GameSessionManager.AreaManager //
// .GroupBy(am => am.AreaItemManager.AreaSlotContainer.AreaID) // .Where(am =>
// AreaInfos.ContainsKey(am.Key)) // .Select(am => ( // AremInfo: AreaInfos[am.Key], // objects: am
// // .SelectMany(am => am.AreaObjectManager.GameObject.Objects?.GameObjectObjectsList ??
// Enumerable.Empty<GameObjectObjectsList>()) // .Where(o => Participants[o.ParticipantID.Id].GUID
// != 34 && (o.ShipMaintenance != null || (o.Building != null &&
// ProgrammSettings.Texts.ContainsKey(o.Guid)))))) // .Where(ao=> ao.objects.Any())

// // .ToLookup(amo => amo.AremInfo.Owner.id);

// //.SelectMany(am => am.AreaObjectManager.GameObject.Objects?.GameObjectObjectsList ??
// Enumerable.Empty<GameObjectObjectsList>()) //.Where(ao => ao.ShipMaintenance != null ||
// (ao.Building != null && ProgrammSettings.Texts.ContainsKey(ao.Guid))) //.ToLookup(go => go.)
// //.ToLookup(go => go.); //var array = new Dictionary<>

// //var ParticipantsObjects = session.SessionData.BinaryData.GameSessionManager.AreaManager
// //.SelectMany(am => am.AreaObjectManager.GameObject.Objects?.GameObjectObjectsList ??
// Enumerable.Empty<GameObjectObjectsList>()) //.Where(ao => ao.ShipMaintenance != null ||
// (ao.Building != null && ProgrammSettings.Texts.ContainsKey(ao.Guid))) //.ToLookup(go => go.)
// //.ToLookup(go => go.); //var array = new Dictionary<> //foreach (var Participant in
// ParticipantsObjects) { //}

// foreach (var areaManager in session.SessionData.BinaryData.GameSessionManager.AreaManager) { var
// gameobjectlist = areaManager.AreaObjectManager.GameObject.Objects?.GameObjectsList; if
// (gameobjectlist == null) { continue; } if
// (AreaInfos.ContainsKey(areaManager.AreaItemManager.AreaSlotContainer.AreaID)) { continue; }
// foreach (var areaObject in areaManager.AreaObjectManager.GameObject.Objects?.GameObjectsList) {
// //Set Participants Names (GUIDs)

// //if (areaObject.ShipMaintenance != null) { //}

// //Debug.WriteLine(ProgrammSettings.Texts[areaObject.Guid]);

// if (areaObject.Building != null && ProgrammSettings.Texts.TryGetValue(areaObject.Guid.GUID, out
// var text)) { Debug.WriteLine(ProgrammSettings.Texts[areaObject.Guid.GUID]); }

// //switch (ProgrammSettings.Templates[areaObject.Guid]) { // case "VisualObject": // case
// "AudioSpots": // case "PositionMarker": // case "Collectable": // case "CollectableOnTerrain": //
// case "LandAnimal": // case "FishShoal": // case "Fish": // case "Bird": // case "Prop": // case
// "QuestLighthouse": // case "QuestObject": // case "FeedbackObject": // case "FeedbackVehicle": //
// case "ThirdpartyFeedback": // case "QuestObjectFeedback": // case "DivingBellObject": // case
// "WorkArea": // case "WorkAreaSlot": // case "Seamine": // case "VisualBuilding_NoLogic": // case
// "TestData_Simple": // case "VisualQuestObject": // case "Inhabitant": // case "MovingMobDummy":
// // case "HarborPropObject": // case "FeedbackVehiclePatrol": // case "SimpleVehicle": // case
// "CollectablePicturePuzzle": // case "RemovableWaterBlocker":

// // case "Farmfield": //Maybe use this? //Ignore break;

// // //Vehicles

// // case "TradeShip": case "WarShip":

// // //Buildings case "Slot": //Mines case "ItemCrafterBuilding": case //
// "CityInstitutionBuilding": case "PublicServiceBuilding": case // "ResidenceBuilding7_Arctic":
// case "Heater_Arctic": case "OilPumpBuilding": case // "Guildhouse": case "HarborWarehouse7": case
// "Market": case "Monument_with_Shipyard": // case "Warehouse": case "FarmBuilding_Arctic": case
// "SlotFactoryBuilding7_Arctic": // case "HarborDepot": case "HeavyFreeAreaBuilding_Arctic": case
// // "FactoryBuilding7_Arctic": case "HarborLandingStage7": case // "FreeAreaBuilding_Arctic": case
// "ResidenceBuilding7": case "FactoryBuilding7": case // "CultureModule": case "BridgeBuilding":
// case "OrnamentalBuilding": case // "HarborBuildingAttacker": case "SlotFactoryBuilding7": case
// "BuildPermitModules": // case "FreeAreaBuilding": case "HeavyFactoryBuilding": case
// "PowerplantBuilding": case // "HeavyFreeAreaBuilding": case "BuildPermitBuilding": case
// "RepairCrane": case // "HarborOffice": case "CultureBuilding": case "WorkforceConnector": case //
// "VisitorPier": case "FarmBuilding": case "HarborWarehouseStrategic": case "Monument": // case
// "Shipyard": case "OrnamentalModule": case "CampaignQuestObject": // break;

// // default: // Debug.WriteLine(ProgrammSettings.Templates[areaObject.Guid]); // break; //}
// ////Items in Storage //foreach (var slotItem in
// areaObject.ItemContainer.SlotContainer.SlotList.SlotContainerSlotListList) { // if
// (slotItem.ProductStackSize > 0) { //
// Participants[areaObject.ParticipantID.Id].AddItemUnused(slotItem.Stack.StackList.GUID,
// slotItem.ProductStackSize); // } //}

// ////Socket Items //foreach (var socketItem in
// areaObject.ItemContainer.SocketContainer.SocketItems.SocketItemsList) { // if (socketItem.GUID >
// 0) { // Participants[areaObject.ParticipantID.Id].AddItemUsed(socketItem, 1); // } //}
// //ShipItems //else if (areaObject.ShipMaintenance is ShipMaintenance _) { //} } } } }

//  //public Dictionary<short, AnnoParticipant> Participants { get; }
//  //public Dictionary<short, AreaInfoList> AreaInfos { get; }
//}

//}