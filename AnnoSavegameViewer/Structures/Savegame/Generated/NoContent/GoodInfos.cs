using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class GoodInfos {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<GoodInfosList> GoodInfosList { get; set; }

  }
}