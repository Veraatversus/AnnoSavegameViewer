using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Block {

    #region Public Properties

    [BinaryContent(Name = "mode", NodeType = BinaryContentTypes.Attribute)]
    public object Mode { get; set; }

    [BinaryContent(Name = "x", NodeType = BinaryContentTypes.Attribute)]
    public object X { get; set; }

    [BinaryContent(Name = "y", NodeType = BinaryContentTypes.Attribute)]
    public object Y { get; set; }

    [BinaryContent(Name = "default", NodeType = BinaryContentTypes.Node)]
    public Default Default { get; set; }

    [BinaryContent(Name = "values", NodeType = BinaryContentTypes.Node)]
    public Values Values { get; set; }

    #endregion Public Properties
  }
}