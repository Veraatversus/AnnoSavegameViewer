using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Layer {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public LayerValue Value { get; set; }

  }
}