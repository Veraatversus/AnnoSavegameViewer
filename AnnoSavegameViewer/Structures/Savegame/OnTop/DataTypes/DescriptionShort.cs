using AnnoSavegameViewer.Serialization.Core;
using System.Diagnostics;

namespace AnnoSavegameViewer.Structures.Savegame {

  [DebuggerDisplay("GUID = {GUID}, {CurrentLang}")]
  public class DescriptionShort : Description {

    #region Public Properties

    [BinaryContent(Name = "GUID", NodeType = BinaryContentTypes.Attribute)]
    public new short GUID { get => (short)base.GUID; set => base.GUID = value; }

    public virtual string CurrentLang => ProgrammSettings.Texts[GUID];

    #endregion Public Properties

    #region Public Constructors

    public DescriptionShort(short guid) {
      GUID = guid;
    }

    public DescriptionShort() {
    }

    #endregion Public Constructors

    #region Public Methods

    public override string ToString() {
      return CurrentLang;
    }

    #endregion Public Methods
  }
}