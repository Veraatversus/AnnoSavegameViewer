using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class MetaGameObjectManager {

[BinaryContent(Name = "NextMetaGameObjectID", NodeType = BinaryContentTypes.Attribute)]
public HexString NextMetaGameObjectID { get; set; }

[BinaryContent(Name = "MetaObjectMap", NodeType = BinaryContentTypes.Node)]
public MetaObjectMap MetaObjectMap { get; set; }

}
}
