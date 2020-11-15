namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class HorizontalEdgesList {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<HorizontalEdgesListList> HorizontalEdgesListList { get; set; }

  }
}