using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class EconomyModifiersListList {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public EconomyModifiersListListValue Value { get; set; }

  }
}