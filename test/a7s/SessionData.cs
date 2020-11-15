using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class SessionData {

[BinaryContent(Name = "BinaryData", NodeType = BinaryContentTypes.Attribute, ConversationType = ConversationTypes.FileDB)]
public BinaryData BinaryData { get; set; }

}
}
