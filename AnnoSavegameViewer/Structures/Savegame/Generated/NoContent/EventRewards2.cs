using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class EventRewards2 {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<EventRewards2List> EventRewards2List { get; set; }

  }
}