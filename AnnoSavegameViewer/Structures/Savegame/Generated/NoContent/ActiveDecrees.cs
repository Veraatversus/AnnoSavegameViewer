namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class ActiveDecrees {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<ActiveDecreesList> ActiveDecreesList { get; set; }

  }
}