namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class DebuffsList {

    #region Public Properties

    [BinaryContent(Name = "DebuffEnd", NodeType = BinaryContentTypes.Attribute)]
    public object DebuffEnd { get; set; }

    [BinaryContent(Name = "DiceDebuff", NodeType = BinaryContentTypes.Attribute)]
    public object DiceDebuff { get; set; }

    #endregion Public Properties
  }
}