namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class SocketItems {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<SocketItemsList> SocketItemsList { get; set; }

  }
}