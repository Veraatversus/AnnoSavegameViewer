using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class MonumentHandler {

[BinaryContent(Name = "CurrentConstruction", NodeType = BinaryContentTypes.Attribute)]
public HexString CurrentConstruction { get; set; }

[BinaryContent(Name = "Timestamp", NodeType = BinaryContentTypes.Attribute)]
public HexString Timestamp { get; set; }

[BinaryContent(Name = "SavedResources", NodeType = BinaryContentTypes.Node)]
public SavedResources SavedResources { get; set; }

}
}
