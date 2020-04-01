using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ResourceBalanceBalanceCivLevelInfosList {

    [BinaryContent(Name = "PersonCount", NodeType = BinaryContentTypes.Attribute)]
    public object PersonCount { get; set; }

    [BinaryContent(Name = "DefaultBuildingCount", NodeType = BinaryContentTypes.Attribute)]
    public object DefaultBuildingCount { get; set; }

    [BinaryContent(Name = "WorkforceAvailable", NodeType = BinaryContentTypes.Attribute)]
    public object WorkforceAvailable { get; set; }

    [BinaryContent(Name = "WorkforceConsumed", NodeType = BinaryContentTypes.Attribute)]
    public object WorkforceConsumed { get; set; }

  }
}