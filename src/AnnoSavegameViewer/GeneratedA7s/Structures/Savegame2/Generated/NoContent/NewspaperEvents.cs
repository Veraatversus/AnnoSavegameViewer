namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class NewspaperEvents {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<NewspaperEventsList> NewspaperEventsList { get; set; }

  }
}