namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class FirstTrainMessageSent {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<FirstTrainMessageSentList> FirstTrainMessageSentList { get; set; }

  }
}