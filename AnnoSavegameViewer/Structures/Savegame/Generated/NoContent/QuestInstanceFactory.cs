using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class QuestInstanceFactory {

    [BinaryContent(Name = "IDManager", NodeType = BinaryContentTypes.Node)]
    public IDManager IDManager { get; set; }

  }
}