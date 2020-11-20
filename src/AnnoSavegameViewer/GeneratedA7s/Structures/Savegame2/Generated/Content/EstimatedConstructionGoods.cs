namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class EstimatedConstructionGoods {

    #region Public Properties

    [BinaryContent(Name = "size", NodeType = BinaryContentTypes.Attribute)]
    public object Size { get; set; }

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<EstimatedConstructionGoodsList> EstimatedConstructionGoodsList { get; set; }

    #endregion Public Properties
  }
}