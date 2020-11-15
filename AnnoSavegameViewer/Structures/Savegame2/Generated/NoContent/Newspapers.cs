namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class Newspapers {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<NewspapersList> NewspapersList { get; set; }

  }
}