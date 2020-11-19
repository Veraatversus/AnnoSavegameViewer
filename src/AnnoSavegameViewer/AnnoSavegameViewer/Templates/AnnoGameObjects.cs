// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSavegameViewer.Templates {
  using AnnoSerializer.Structures.DataTypes;
  using System.Collections.Generic;
  using System.Linq;
  using AnnoSerializer.Structures.Generated.a7s;
  using AnnoSerializer;

  public class AnnoGameObjects {

    #region Public Properties

    public HashSet<AnnoItem> Items { get; } = new HashSet<AnnoItem>();
    public HashSet<AnnoItem> Upgrades { get; } = new HashSet<AnnoItem>();
    public HashSet<AnnoItem> GameObjects { get; } = new HashSet<AnnoItem>();

    #endregion Public Properties

    #region Public Constructors

    public AnnoGameObjects(A7s_File a7s) {
      if (a7s == null)
        throw new System.ArgumentNullException(nameof(a7s));

      var baseNode = a7s.A7s_File_RDA.Block_03.Data_a7s;
      foreach (var session in baseNode.MetaGameManager.GameSessions.Values) {
        //Participants
        var Participants = session
          .SessionData
          .BinaryData
          .GameSessionManager
          .SessionParticipantManager
          .ParticipantIDToObjects
          .Values
          .ToDictionary(p => p.Value.Id, p => new AnnoParticipant(p.Value.Id));

        //Find Participants Objects
        var participantsObjects = session
          .SessionData
          .BinaryData
          .GameSessionManager
          .AreaManagers[0]
          .AreaObjectManager
          .GameObject
          .Objects
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
         .AreaInfo;

        //AreaManager
        foreach (var areaManager in session.SessionData.BinaryData.GameSessionManager.AreaManagers) {
          _ = AreaInfos.TryGetValue(areaManager.AreaItemManager.AreaSlotContainer.AreaID, out var areaInfo);
          if (areaInfo != null) {
            foreach (var kontorItem in areaManager.AreaItemManager.AreaSlotContainer.SlotList ?? Enumerable.Empty<SlotListValue>()) {
              foreach (var item in kontorItem.Stack.Values ?? Enumerable.Empty<StackValue>()) {
                if (item.GUID?.GUID != null) {
                  _ = Items.Add(new AnnoItem {
                    GUID = item.GUID,
                    Amount = 1,
                    InUse = false,
                    Participant = Participants[areaInfo.Owner.Id],
                    AreaManager = areaManager,
                    AreaInfo = areaInfo,
                    Session = session
                  });
                }
              }
            }
          }
          //GameObjects
          foreach (var gameObject in areaManager.AreaObjectManager.GameObject.Objects) {
            var participant = Participants[gameObject.ParticipantID.Id];

            if (gameObject.ShipMaintenance != null || (gameObject.Building != null && LanguageService.Texts.ContainsKey(gameObject.Guid.GUID)) /*&& participant.GUID.GUID != 34*/) {
              _ = GameObjects.Add(new AnnoItem {
                GUID = gameObject.Guid,
                Participant = participant,
                ParentObject = gameObject,
                AreaManager = areaManager,
                AreaInfo = areaInfo,
                Session = session,
                Amount = 1
              });

              foreach (var slotItem in gameObject.ItemContainer?.SlotContainer?.SlotList ?? Enumerable.Empty<SlotContainerSlotListValue>()) {
                if (slotItem?.Stack != null) {
                  foreach (var stack in slotItem?.Stack) {
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

              foreach (var socketItem in gameObject.ItemContainer?.SocketContainer?.SocketItems ?? Enumerable.Empty<SocketItemsValue>()) {
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
                foreach (var upgrade in gameObject.UpgradeList.UpgradeGUIDs ?? Enumerable.Empty<DescriptionInt>()) {
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