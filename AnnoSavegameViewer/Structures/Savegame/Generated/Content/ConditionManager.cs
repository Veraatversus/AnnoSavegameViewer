using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ConditionManager {

    [BinaryContent(Name = "UniqueIDCounter", NodeType = BinaryContentTypes.Attribute)]
    public object UniqueIDCounter { get; set; }

    [BinaryContent(Name = "NonNetworkUniqueIDCounter", NodeType = BinaryContentTypes.Attribute)]
    public object NonNetworkUniqueIDCounter { get; set; }

    [BinaryContent(Name = "ActionIDCounter", NodeType = BinaryContentTypes.Attribute)]
    public object ActionIDCounter { get; set; }

    [BinaryContent(Name = "TutorialManager", NodeType = BinaryContentTypes.Node)]
    public TutorialManager TutorialManager { get; set; }

    [BinaryContent(Name = "ActionByID", NodeType = BinaryContentTypes.Node)]
    public ActionByID ActionByID { get; set; }

    [BinaryContent(Name = "Conditions", NodeType = BinaryContentTypes.Node)]
    public Conditions Conditions { get; set; }

  }
}