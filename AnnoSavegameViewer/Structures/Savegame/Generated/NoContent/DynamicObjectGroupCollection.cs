namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class DynamicObjectGroupCollection {

    [BinaryContent(Name = "ObjectGroups", NodeType = BinaryContentTypes.Node)]
    public ObjectGroups ObjectGroups { get; set; }

  }
}