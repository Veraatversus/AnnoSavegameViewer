using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class SharedViewsList {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public SharedViewsListValue Value { get; set; }

  }
}