using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class MetaMessageManager {

[BinaryContent(Name = "NGT", NodeType = BinaryContentTypes.Node)]
public NGT NGT { get; set; }

[BinaryContent(Name = "ActionQueue", NodeType = BinaryContentTypes.Node)]
public ActionQueue ActionQueue { get; set; }

}
}
