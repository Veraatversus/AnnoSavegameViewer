using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Newspapers {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<NewspapersList> NewspapersList { get; set; }

  }
}