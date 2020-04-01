using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class StreetUpgradeAreasList {

    [BinaryContent(Name = "Center", NodeType = BinaryContentTypes.Attribute)]
    public object Center { get; set; }

    [BinaryContent(Name = "CurrentSideLength", NodeType = BinaryContentTypes.Attribute)]
    public object CurrentSideLength { get; set; }

    [BinaryContent(Name = "SideLengthMax", NodeType = BinaryContentTypes.Attribute)]
    public object SideLengthMax { get; set; }

  }
}