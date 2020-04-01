using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class QuestMetaData {

    [BinaryContent(Name = "QuestArea", NodeType = BinaryContentTypes.Attribute)]
    public object QuestArea { get; set; }

  }
}