using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class EconomyModifiersListListValue {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public EconomyModifiersListListValueValue Value { get; set; }

  }
}