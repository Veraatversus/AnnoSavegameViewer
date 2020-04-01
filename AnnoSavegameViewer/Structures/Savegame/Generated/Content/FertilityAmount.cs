using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class FertilityAmount {

    [BinaryContent(Name = "fertilityAmount", NodeType = BinaryContentTypes.Attribute)]
    public object FertilityAmountItem { get; set; }

  }
}