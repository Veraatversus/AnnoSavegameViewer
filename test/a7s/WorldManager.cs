using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class WorldManager {

[BinaryContent(Name = "StreetMap", NodeType = BinaryContentTypes.Node)]
public StreetMap StreetMap { get; set; }

[BinaryContent(Name = "RemovedProps", NodeType = BinaryContentTypes.Node)]
public RemovedProps RemovedProps { get; set; }

[BinaryContent(Name = "ObjectSpawnerMap", NodeType = BinaryContentTypes.Node)]
public ObjectSpawnerMap ObjectSpawnerMap { get; set; }

}
}
