using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class CurrentMinesList {

    #region Public Properties

    [BinaryContent(Name = "pos", NodeType = BinaryContentTypes.Attribute)]
    public object Pos { get; set; }

    [BinaryContent(Name = "area", NodeType = BinaryContentTypes.Attribute)]
    public object Area { get; set; }

    #endregion Public Properties
  }
}