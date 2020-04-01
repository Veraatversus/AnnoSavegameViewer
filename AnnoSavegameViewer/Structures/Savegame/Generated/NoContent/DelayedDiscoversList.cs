using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class DelayedDiscoversList {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public DelayedDiscoversListValue Value { get; set; }

  }
}