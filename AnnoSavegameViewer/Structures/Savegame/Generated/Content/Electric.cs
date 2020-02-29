using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Electric {

    [BinaryContent(Name = "IsPowered", NodeType = BinaryContentTypes.Attribute)]
    public object IsPowered { get; set; }

  }
}