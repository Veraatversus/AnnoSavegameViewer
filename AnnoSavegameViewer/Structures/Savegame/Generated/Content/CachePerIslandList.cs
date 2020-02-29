using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class CachePerIslandList {

    #region Public Properties

    [BinaryContent(Name = "Ownage", NodeType = BinaryContentTypes.Attribute)]
    public object Ownage { get; set; }

    [BinaryContent(Name = "Error", NodeType = BinaryContentTypes.Attribute)]
    public object Error { get; set; }

    [BinaryContent(Name = "PreviousRejects", NodeType = BinaryContentTypes.Node)]
    public PreviousRejects PreviousRejects { get; set; }

    [BinaryContent(Name = "CoastErros", NodeType = BinaryContentTypes.Node)]
    public CoastErros CoastErros { get; set; }

    #endregion Public Properties
  }
}