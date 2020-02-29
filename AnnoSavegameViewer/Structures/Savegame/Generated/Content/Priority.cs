using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Priority {

    [BinaryContent(Name = "Priority", NodeType = BinaryContentTypes.Attribute)]
    public object PriorityItem { get; set; }

  }
}