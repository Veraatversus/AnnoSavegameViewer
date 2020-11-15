namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class VerticalEdgesList {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<VerticalEdgesListList> VerticalEdgesListList { get; set; }

  }
}