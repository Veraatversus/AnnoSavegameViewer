using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class AreaUniquesList {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<AreaUniquesListList> AreaUniquesListList { get; set; }

  }
}