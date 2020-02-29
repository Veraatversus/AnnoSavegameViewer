using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class FirstTrainMessageSent {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<FirstTrainMessageSentList> FirstTrainMessageSentList { get; set; }

  }
}