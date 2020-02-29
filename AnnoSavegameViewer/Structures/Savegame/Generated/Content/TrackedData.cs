using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class TrackedData {

    [BinaryContent(Name = "LowTracked", NodeType = BinaryContentTypes.Attribute)]
    public object LowTracked { get; set; }

    [BinaryContent(Name = "HighTracked", NodeType = BinaryContentTypes.Attribute)]
    public object HighTracked { get; set; }

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Attribute)]
    public List<object> None { get; set; }

  }
}