namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class AreaUniquesList {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<AreaUniquesListList> AreaUniquesListList { get; set; }

  }
}