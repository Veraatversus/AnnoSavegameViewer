using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class RunningQuestsListQuestMetaData {

    [BinaryContent(Name = "QuestArea", NodeType = BinaryContentTypes.Attribute)]
    public object QuestArea { get; set; }

    [BinaryContent(Name = "RelatedQuestGUID", NodeType = BinaryContentTypes.Attribute)]
    public object RelatedQuestGUID { get; set; }

  }
}