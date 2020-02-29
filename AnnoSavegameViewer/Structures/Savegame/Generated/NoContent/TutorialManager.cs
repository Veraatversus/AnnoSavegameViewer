using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class TutorialManager {

    [BinaryContent(Name = "TutorialConditionKeys", NodeType = BinaryContentTypes.Node)]
    public TutorialConditionKeys TutorialConditionKeys { get; set; }

  }
}