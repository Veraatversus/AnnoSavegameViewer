using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class MetaUnlockManager {

[BinaryContent(Name = "LockState", NodeType = BinaryContentTypes.Node)]
public LockState LockState { get; set; }

}
}
