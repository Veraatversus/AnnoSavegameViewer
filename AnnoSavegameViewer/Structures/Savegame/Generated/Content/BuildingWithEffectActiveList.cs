using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class BuildingWithEffectActiveList {

    [BinaryContent(Name = "Guid", NodeType = BinaryContentTypes.Attribute)]
    public object Guid { get; set; }

    [BinaryContent(Name = "Amount", NodeType = BinaryContentTypes.Attribute)]
    public object Amount { get; set; }

  }
}