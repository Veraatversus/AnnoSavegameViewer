using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class RunningQuests {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<RunningQuestsList> RunningQuestsList { get; set; }

  }
}