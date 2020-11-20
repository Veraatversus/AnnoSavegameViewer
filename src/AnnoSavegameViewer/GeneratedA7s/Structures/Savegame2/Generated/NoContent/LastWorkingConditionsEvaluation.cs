namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class LastWorkingConditionsEvaluation {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<LastWorkingConditionsEvaluationList> LastWorkingConditionsEvaluationList { get; set; }

  }
}