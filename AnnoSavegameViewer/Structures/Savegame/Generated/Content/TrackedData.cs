using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class TrackedData {

    [BinaryContent(Name = "HighTracked", NodeType = BinaryContentTypes.Attribute)]
    public object HighTracked { get; set; }

  }
}