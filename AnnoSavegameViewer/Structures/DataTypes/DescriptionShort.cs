namespace AnnoSavegameViewer.Structures.DataTypes {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Diagnostics;

  [DebuggerDisplay("GUID = {GUID}, {CurrentLang}")]
  public class DescriptionShort : Description {

    #region Public Properties

    [BinaryContent(Name = "GUID", NodeType = BinaryContentTypes.Both)]
    public new short GUID { get; set; }

    public override string CurrentLang {
      get { _ = ProgrammSettings.Texts.TryGetValue(GUID, out var result); return result ?? GUID.ToString(); }
    }

    #endregion Public Properties

    #region Public Constructors

    public DescriptionShort(short guid) => GUID = guid;

    public DescriptionShort() {
    }

    #endregion Public Constructors
  }
}