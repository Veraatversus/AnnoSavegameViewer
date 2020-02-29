using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class AreaTriggered {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<AreaTriggeredList> AreaTriggeredList { get; set; }

  }
}