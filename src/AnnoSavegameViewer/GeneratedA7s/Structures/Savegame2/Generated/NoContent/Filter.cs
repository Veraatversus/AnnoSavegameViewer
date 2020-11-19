namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class Filter {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<FilterList> FilterList { get; set; }

  }
}