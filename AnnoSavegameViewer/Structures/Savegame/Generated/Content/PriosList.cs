using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class PriosList {

    [BinaryContent(Name = "Time", NodeType = BinaryContentTypes.Attribute)]
    public object Time { get; set; }

    [BinaryContent(Name = "Count", NodeType = BinaryContentTypes.Attribute)]
    public object Count { get; set; }

    [BinaryContent(Name = "Modifier", NodeType = BinaryContentTypes.Attribute)]
    public object Modifier { get; set; }

  }
}