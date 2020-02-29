using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class LastWorkingConditionsEvaluation {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<LastWorkingConditionsEvaluationList> LastWorkingConditionsEvaluationList { get; set; }

  }
}