using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class PossibleThirdPartiesList {

    [BinaryContent(Name = "ProfileGUID", NodeType = BinaryContentTypes.Attribute)]
    public object ProfileGUID { get; set; }

    [BinaryContent(Name = "ActiveRegions", NodeType = BinaryContentTypes.Node)]
    public ActiveRegions ActiveRegions { get; set; }

  }
}