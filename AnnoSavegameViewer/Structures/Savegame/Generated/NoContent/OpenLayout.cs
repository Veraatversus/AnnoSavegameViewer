using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class OpenLayout {

    [BinaryContent(Name = "RailroadOrnamentals", NodeType = BinaryContentTypes.Node)]
    public RailroadOrnamentals RailroadOrnamentals { get; set; }

  }
}