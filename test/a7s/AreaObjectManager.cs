using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class AreaObjectManager {

[BinaryContent(Name = "GameObjectIDCounter", NodeType = BinaryContentTypes.Attribute)]
public HexString GameObjectIDCounter { get; set; }

[BinaryContent(Name = "NonGameObjectIDCounter", NodeType = BinaryContentTypes.Attribute)]
public HexString NonGameObjectIDCounter { get; set; }

[BinaryContent(Name = "QueuedChangeGUID", NodeType = BinaryContentTypes.Node)]
public QueuedChangeGUID QueuedChangeGUID { get; set; }

[BinaryContent(Name = "QueuedDeletes", NodeType = BinaryContentTypes.Attribute)]
public HexString QueuedDeletes { get; set; }

[BinaryContent(Name = "ObjectGroupFilterCollection", NodeType = BinaryContentTypes.Node)]
public ObjectGroupFilterCollection ObjectGroupFilterCollection { get; set; }

[BinaryContent(Name = "ObjectGroupCollection", NodeType = BinaryContentTypes.Node)]
public ObjectGroupCollection ObjectGroupCollection { get; set; }

[BinaryContent(Name = "GameObject", NodeType = BinaryContentTypes.Node)]
public GameObject GameObject { get; set; }

[BinaryContent(Name = "Nature", NodeType = BinaryContentTypes.Node)]
public Nature Nature { get; set; }

}
}
