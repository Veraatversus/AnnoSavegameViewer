using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class QuestObject {

[BinaryContent(Name = "QuestIDs", NodeType = BinaryContentTypes.Node)]
public QuestIDs QuestIDs { get; set; }

[BinaryContent(Name = "ObjectWasVisible", NodeType = BinaryContentTypes.Node)]
public ObjectWasVisible ObjectWasVisible { get; set; }

[BinaryContent(Name = "OverwriteVisualParticipant", NodeType = BinaryContentTypes.Node)]
public OverwriteVisualParticipant OverwriteVisualParticipant { get; set; }

}
}
