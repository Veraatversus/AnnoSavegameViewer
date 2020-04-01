using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class TutorialManager {

    [BinaryContent(Name = "TutorialConditionKeys", NodeType = BinaryContentTypes.Node)]
    public TutorialConditionKeys TutorialConditionKeys { get; set; }

  }
}