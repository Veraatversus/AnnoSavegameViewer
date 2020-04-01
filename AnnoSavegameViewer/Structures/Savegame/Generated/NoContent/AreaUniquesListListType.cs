using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class AreaUniquesListListType {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public AreaUniquesListListTypeValue Value { get; set; }

  }
}