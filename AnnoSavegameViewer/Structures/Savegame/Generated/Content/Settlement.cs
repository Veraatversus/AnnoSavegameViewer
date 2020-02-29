using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Settlement {

    [BinaryContent(Name = "LastRateTick", NodeType = BinaryContentTypes.Attribute)]
    public object LastRateTick { get; set; }

    [BinaryContent(Name = "IslandCount", NodeType = BinaryContentTypes.Attribute)]
    public object IslandCount { get; set; }

    [BinaryContent(Name = "SettleHandler", NodeType = BinaryContentTypes.Node)]
    public SettleHandler SettleHandler { get; set; }

    [BinaryContent(Name = "Island", NodeType = BinaryContentTypes.Node)]
    public Island Island { get; set; }

  }
}