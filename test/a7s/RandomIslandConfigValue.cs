using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class RandomIslandConfigValue {

[BinaryContent(Name = "Type", NodeType = BinaryContentTypes.Node)]
public RandomIslandConfigValueType Type { get; set; }

[BinaryContent(Name = "Difficulty", NodeType = BinaryContentTypes.Node)]
public ValueDifficulty Difficulty { get; set; }

}
}
