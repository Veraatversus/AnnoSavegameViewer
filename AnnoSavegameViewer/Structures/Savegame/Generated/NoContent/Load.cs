namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class Load {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<LoadList> LoadList { get; set; }

  }
}