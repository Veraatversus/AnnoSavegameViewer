using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class TransporterQueue {

[BinaryContent(Name = "QueuedTransporters", NodeType = BinaryContentTypes.Node)]
public QueuedTransporters QueuedTransporters { get; set; }

[BinaryContent(Name = "ProcessingTransporters", NodeType = BinaryContentTypes.Node)]
public ProcessingTransporters ProcessingTransporters { get; set; }

}
}
