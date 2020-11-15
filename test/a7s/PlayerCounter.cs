using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class PlayerCounter {

[BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
public PlayerCounterValue Value { get; set; }

}
}
