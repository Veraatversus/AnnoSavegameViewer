using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class AreaObjectManager {

    #region Public Properties

    [BinaryContent(Name = "GameObjectIDCounter", NodeType = BinaryContentTypes.Attribute)]
    public long GameObjectIDCounter { get; set; }

    [BinaryContent(Name = "NonGameObjectIDCounter", NodeType = BinaryContentTypes.Attribute)]
    public long NonGameObjectIDCounter { get; set; }

    [BinaryContent(Name = "QueuedDeletes", NodeType = BinaryContentTypes.Attribute)]
    public object QueuedDeletes { get; set; }

    [BinaryContent(Name = "QueuedChangeGUID", NodeType = BinaryContentTypes.Node)]
    public QueuedChangeGUID QueuedChangeGUID { get; set; }

    [BinaryContent(Name = "ObjectGroupFilterCollection", NodeType = BinaryContentTypes.Node)]
    public ObjectGroupFilterCollection ObjectGroupFilterCollection { get; set; }

    [BinaryContent(Name = "ObjectGroupCollection", NodeType = BinaryContentTypes.Node)]
    public ObjectGroupCollection ObjectGroupCollection { get; set; }

    [BinaryContent(Name = "GameObject", NodeType = BinaryContentTypes.Node)]
    public GameObject GameObject { get; set; }

    [BinaryContent(Name = "Nature", NodeType = BinaryContentTypes.Node)]
    public Nature Nature { get; set; }

    #endregion Public Properties
  }
}