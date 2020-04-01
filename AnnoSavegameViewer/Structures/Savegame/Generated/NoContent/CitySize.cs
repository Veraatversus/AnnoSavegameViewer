using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class CitySize {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public CitySizeValue Value { get; set; }

  }
}