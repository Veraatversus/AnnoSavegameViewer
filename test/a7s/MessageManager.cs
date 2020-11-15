using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class MessageManager {

[BinaryContent(Name = "NGT", NodeType = BinaryContentTypes.Node)]
public MessageManagerNGT NGT { get; set; }

[BinaryContent(Name = "ActionQueue", NodeType = BinaryContentTypes.Node)]
public MessageManagerActionQueue ActionQueue { get; set; }

}
}
