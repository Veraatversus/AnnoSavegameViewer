using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class ConditionManager {

[BinaryContent(Name = "UniqueIDCounter", NodeType = BinaryContentTypes.Attribute)]
public HexString UniqueIDCounter { get; set; }

[BinaryContent(Name = "NonNetworkUniqueIDCounter", NodeType = BinaryContentTypes.Attribute)]
public HexString NonNetworkUniqueIDCounter { get; set; }

[BinaryContent(Name = "ActionIDCounter", NodeType = BinaryContentTypes.Attribute)]
public HexString ActionIDCounter { get; set; }

[BinaryContent(Name = "TutorialManager", NodeType = BinaryContentTypes.Node)]
public TutorialManager TutorialManager { get; set; }

[BinaryContent(Name = "ActionByID", NodeType = BinaryContentTypes.Node)]
public ActionByID ActionByID { get; set; }

[BinaryContent(Name = "Conditions", NodeType = BinaryContentTypes.Node)]
public Conditions Conditions { get; set; }

}
}
