using AnnoSavegameViewer.Structures.Savegame;
using AnnoSavegameViewer.Structures.Savegame.Generated;
using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace AnnoSavegameViewer.Templates {

  [DebuggerDisplay("{Amount}x {GUID}")]
  public class AnnoItem : IEquatable<AnnoItem> {

    #region Public Properties

    public DescriptionInt GUID { get; set; }
    public int Amount { get; set; }
    public bool InUse { get; internal set; }
    public AnnoParticipant Participant { get; internal set; }
    public GameObjectObjectsList ParentObject { get; internal set; }
    public AreaManager AreaManager { get; internal set; }
    public AreaInfoList AreaInfo { get; internal set; }
    public GameSessionsList Session { get; internal set; }

    #endregion Public Properties

    #region Public Methods

    public bool Equals([AllowNull] AnnoItem other) {
      return GUID?.GUID == other?.GUID?.GUID;
    }

    #endregion Public Methods
  }
}