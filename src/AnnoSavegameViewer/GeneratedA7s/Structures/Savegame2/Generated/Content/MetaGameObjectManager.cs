namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class MetaGameObjectManager {

    [BinaryContent(Name = "NextMetaGameObjectID", NodeType = BinaryContentTypes.Attribute)]
    public object NextMetaGameObjectID { get; set; }

    [BinaryContent(Name = "MetaObjectMap", NodeType = BinaryContentTypes.Node)]
    public MetaObjectMap MetaObjectMap { get; set; }

  }
}