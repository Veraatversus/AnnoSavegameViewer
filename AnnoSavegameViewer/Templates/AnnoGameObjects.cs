namespace AnnoSavegameViewer.Templates {
  using AnnoSavegameViewer.Structures.DataTypes;
  using AnnoSavegameViewer.Structures.Savegame;
  using AnnoSavegameViewer.Structures.Savegame.Generated;
  using System.Collections.Generic;
  using System.Linq;

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
          .AreaManagers
          .AreaManager[0]
          .AreaObjectManager
          .GameObject
          .Objects
          .GameObjectsList
          .Where(o => o.Profile is not null)
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
        foreach (var areaManager in session.SessionData.BinaryData.GameSessionManager.AreaManagers.AreaManager) {
          _ = AreaInfos.TryGetValue(areaManager.AreaItemManager.AreaSlotContainer.AreaID, out var areaInfo);
          if (areaInfo != null) {
            foreach (var kontorItem in areaManager.AreaItemManager.AreaSlotContainer.SlotList.AreaSlotContainerSlotListList ?? Enumerable.Empty<AreaSlotContainerSlotListList>()) {
              foreach (var item in kontorItem.Stack.AreaSlotContainerSlotListListStackList ?? Enumerable.Empty<AreaSlotContainerSlotListListStackList>()) {
                if (item.GUID?.GUID != null) {
                  _ = Items.Add(new AnnoItem {
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

            if (gameObject.ShipMaintenance != null || (gameObject.Building != null && ProgrammSettings.Texts.ContainsKey(gameObject.Guid.GUID)) /*&& participant.GUID.GUID != 34*/) {
              _ = GameObjects.Add(new AnnoItem {
                GUID = gameObject.Guid,
                Participant = participant,
                ParentObject = gameObject,
                AreaManager = areaManager,
                AreaInfo = areaInfo,
                Session = session,
                Amount = 1
              });

              foreach (var slotItem in gameObject.ItemContainer?.SlotContainer?.SlotList?.SlotContainerSlotListList ?? Enumerable.Empty<SlotContainerSlotListList>()) {
                if (slotItem?.Stack?.StackList != null) {
                  foreach (var stack in slotItem?.Stack?.StackList) {
                    if (stack?.GUID != null) {
                      _ = Items.Add(new AnnoItem {
                        GUID = stack.GUID,
                        Amount = slotItem.ProductStackSize > 0 ? slotItem.ProductStackSize : 1,
                        InUse = false,
                        Participant = participant,
                        ParentObject = gameObject,
                        AreaManager = areaManager,
                        AreaInfo = areaInfo,
                        Session = session
                      });
                    }
                  }
                }
              }

              foreach (var socketItem in gameObject.ItemContainer?.SocketContainer?.SocketItems?.SocketItemsList ?? Enumerable.Empty<SocketItemsList>()) {
                if (socketItem.GUID != null) {
                  _ = Items.Add(new AnnoItem {
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
                  _ = Upgrades.Add(new AnnoItem {
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
              }
            }
          }
        }
      }
    }

    #endregion Public Constructors
  }
}