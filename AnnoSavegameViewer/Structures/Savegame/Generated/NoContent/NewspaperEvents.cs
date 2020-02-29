using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class NewspaperEvents {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<NewspaperEventsList> NewspaperEventsList { get; set; }

  }
}