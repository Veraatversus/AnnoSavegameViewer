using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Objects {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<ObjectsList> ObjectsList { get; set; }

  }
}