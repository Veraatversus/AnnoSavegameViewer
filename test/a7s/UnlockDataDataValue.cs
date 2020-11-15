using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class UnlockDataDataValue {

[BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
public UnlockDataDataValuesNoneValue Value { get; set; }

[BinaryContent(Name = "LockState", NodeType = BinaryContentTypes.Node)]
public NoneLockState LockState { get; set; }

}
}
