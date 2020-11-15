namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class DelayedDiscovers {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<DelayedDiscoversList> DelayedDiscoversList { get; set; }

  }
}