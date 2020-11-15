namespace AnnoSavegameViewer.Templates {
  using AnnoSerializer.Structures.DataTypes;
  using AnnoSerializer.Structures.Generated.a7s;
  using System;
  using System.Diagnostics;
  using System.Diagnostics.CodeAnalysis;

  [DebuggerDisplay("{Amount}x {GUID}")]
  public class AnnoItem : IEquatable<AnnoItem> {

    #region Public Properties

    public DescriptionInt GUID { get; set; }
    public int Amount { get; set; }
    public bool InUse { get; internal set; }
    public AnnoParticipant Participant { get; internal set; }
    public GameObjectObjectsValue ParentObject { get; internal set; }
    public AreaManagersValue AreaManager { get; internal set; }
    public AreaInfoValue AreaInfo { get; internal set; }
    public GameSessionsValue Session { get; internal set; }

    #endregion Public Properties

    #region Public Methods

    public bool Equals([AllowNull] AnnoItem other) => GUID?.GUID == other?.GUID?.GUID;

    public override bool Equals(object obj) => Equals(obj as AnnoItem);

    #endregion Public Methods
  }
}