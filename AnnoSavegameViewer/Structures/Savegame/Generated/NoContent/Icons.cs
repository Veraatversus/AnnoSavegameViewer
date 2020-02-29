using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Icons {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<IconsList> IconsList { get; set; }

  }
}