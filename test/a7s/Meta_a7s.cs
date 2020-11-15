using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class Meta_a7s {

[BinaryContent(Name = "CorporationFileVersion", NodeType = BinaryContentTypes.Attribute)]
public Int32 CorporationFileVersion { get; set; }

[BinaryContent(Name = "CorporationVersionName", NodeType = BinaryContentTypes.Attribute)]
public String CorporationVersionName { get; set; }

[BinaryContent(Name = "LastModTime", NodeType = BinaryContentTypes.Attribute)]
public DateTime LastModTime { get; set; }

[BinaryContent(Name = "CorporationSaveGameName", NodeType = BinaryContentTypes.Attribute)]
public String CorporationSaveGameName { get; set; }

}
}
