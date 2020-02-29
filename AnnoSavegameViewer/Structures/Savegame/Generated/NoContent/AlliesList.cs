using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class AlliesList {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public AlliesListValue Value { get; set; }

  }
}