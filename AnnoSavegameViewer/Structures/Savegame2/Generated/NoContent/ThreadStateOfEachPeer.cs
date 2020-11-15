namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class ThreadStateOfEachPeer {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<ThreadStateOfEachPeerList> ThreadStateOfEachPeerList { get; set; }

  }
}