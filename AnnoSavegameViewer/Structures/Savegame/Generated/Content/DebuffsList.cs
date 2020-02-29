using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class DebuffsList {

    #region Public Properties

    [BinaryContent(Name = "DebuffEnd", NodeType = BinaryContentTypes.Attribute)]
    public object DebuffEnd { get; set; }

    [BinaryContent(Name = "DiceDebuff", NodeType = BinaryContentTypes.Attribute)]
    public object DiceDebuff { get; set; }

    #endregion Public Properties
  }
}