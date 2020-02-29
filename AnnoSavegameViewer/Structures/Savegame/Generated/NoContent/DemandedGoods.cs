using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class DemandedGoods {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public DemandedGoodsList DemandedGoodsList { get; set; }

  }
}