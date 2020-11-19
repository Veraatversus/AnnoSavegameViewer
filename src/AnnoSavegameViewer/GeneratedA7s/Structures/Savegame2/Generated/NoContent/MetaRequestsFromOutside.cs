namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class MetaRequestsFromOutside {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<MetaRequestsFromOutsideList> MetaRequestsFromOutsideList { get; set; }

  }
}