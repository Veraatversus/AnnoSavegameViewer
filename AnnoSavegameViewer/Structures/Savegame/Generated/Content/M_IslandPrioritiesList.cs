using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class M_IslandPrioritiesList {

    [BinaryContent(Name = "AreaID", NodeType = BinaryContentTypes.Attribute)]
    public object AreaID { get; set; }

    [BinaryContent(Name = "MoneyCost", NodeType = BinaryContentTypes.Attribute)]
    public object MoneyCost { get; set; }

    [BinaryContent(Name = "ShareIndex", NodeType = BinaryContentTypes.Attribute)]
    public object ShareIndex { get; set; }

    [BinaryContent(Name = "Prio", NodeType = BinaryContentTypes.Attribute)]
    public object Prio { get; set; }

    [BinaryContent(Name = "MissingMoney", NodeType = BinaryContentTypes.Attribute)]
    public object MissingMoney { get; set; }

    [BinaryContent(Name = "ShareCount", NodeType = BinaryContentTypes.Attribute)]
    public object ShareCount { get; set; }

    [BinaryContent(Name = "PrioType", NodeType = BinaryContentTypes.Node)]
    public PrioType PrioType { get; set; }

  }
}