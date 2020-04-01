using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ActiveDecreesList {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public ActiveDecreesListValue Value { get; set; }

  }
}