using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Owner {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public OwnerValue Value { get; set; }

  }
}