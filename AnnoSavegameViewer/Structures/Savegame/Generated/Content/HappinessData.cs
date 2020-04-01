using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class HappinessData {

    [BinaryContent(Name = "areaID", NodeType = BinaryContentTypes.Attribute)]
    public object AreaID { get; set; }

    [BinaryContent(Name = "avgHappiness", NodeType = BinaryContentTypes.Attribute)]
    public object AvgHappiness { get; set; }

    [BinaryContent(Name = "pollution", NodeType = BinaryContentTypes.Attribute)]
    public object Pollution { get; set; }

    [BinaryContent(Name = "warfare", NodeType = BinaryContentTypes.Attribute)]
    public object Warfare { get; set; }

    [BinaryContent(Name = "owner", NodeType = BinaryContentTypes.Node)]
    public HappinessDataOwner Owner { get; set; }

    [BinaryContent(Name = "workingConditions", NodeType = BinaryContentTypes.Node)]
    public WorkingConditions WorkingConditions { get; set; }

  }
}