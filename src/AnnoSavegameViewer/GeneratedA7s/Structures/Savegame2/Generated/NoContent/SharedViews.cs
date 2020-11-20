namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class SharedViews {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<SharedViewsList> SharedViewsList { get; set; }

  }
}