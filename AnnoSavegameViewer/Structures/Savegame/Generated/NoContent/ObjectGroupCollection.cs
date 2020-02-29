using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ObjectGroupCollection {

    [BinaryContent(Name = "ObjectGroups", NodeType = BinaryContentTypes.Node)]
    public ObjectGroupCollectionObjectGroups ObjectGroups { get; set; }

  }
}