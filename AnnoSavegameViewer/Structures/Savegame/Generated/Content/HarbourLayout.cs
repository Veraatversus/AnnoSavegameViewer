namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class HarbourLayout {

    #region Public Properties

    [BinaryContent(Name = "HarborCount", NodeType = BinaryContentTypes.Attribute)]
    public object HarborCount { get; set; }

    [BinaryContent(Name = "ID", NodeType = BinaryContentTypes.Attribute)]
    public List<object> ID { get; set; }

    [BinaryContent(Name = "harborBlockExtension", NodeType = BinaryContentTypes.Attribute)]
    public object HarborBlockExtension { get; set; }

    [BinaryContent(Name = "Harbor", NodeType = BinaryContentTypes.Node)]
    public List<Harbor> Harbor { get; set; }

    #endregion Public Properties
  }
}