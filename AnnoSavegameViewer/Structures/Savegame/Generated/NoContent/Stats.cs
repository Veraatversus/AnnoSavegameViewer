using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Stats {

    [BinaryContent(Name = "AreaCounter", NodeType = BinaryContentTypes.Node)]
    public AreaCounter AreaCounter { get; set; }

    [BinaryContent(Name = "SessionCounter", NodeType = BinaryContentTypes.Node)]
    public SessionCounter SessionCounter { get; set; }

    [BinaryContent(Name = "RegionCounter", NodeType = BinaryContentTypes.Node)]
    public RegionCounter RegionCounter { get; set; }

    [BinaryContent(Name = "GlobalCounter", NodeType = BinaryContentTypes.Node)]
    public GlobalCounter GlobalCounter { get; set; }

  }
}