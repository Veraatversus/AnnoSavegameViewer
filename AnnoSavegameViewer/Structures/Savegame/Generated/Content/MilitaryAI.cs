using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class MilitaryAI {

    [BinaryContent(Name = "TimeUntilUpdate", NodeType = BinaryContentTypes.Attribute)]
    public object TimeUntilUpdate { get; set; }

    [BinaryContent(Name = "TimeUntilAttack", NodeType = BinaryContentTypes.Attribute)]
    public object TimeUntilAttack { get; set; }

    [BinaryContent(Name = "TimeUntilBuild", NodeType = BinaryContentTypes.Attribute)]
    public object TimeUntilBuild { get; set; }

    [BinaryContent(Name = "TimeUntilDefense", NodeType = BinaryContentTypes.Attribute)]
    public object TimeUntilDefense { get; set; }

    [BinaryContent(Name = "TimeUntilEscort", NodeType = BinaryContentTypes.Attribute)]
    public object TimeUntilEscort { get; set; }

    [BinaryContent(Name = "TimeUntilPatrol", NodeType = BinaryContentTypes.Attribute)]
    public object TimeUntilPatrol { get; set; }

    [BinaryContent(Name = "TimeUntilRepairCheck", NodeType = BinaryContentTypes.Attribute)]
    public object TimeUntilRepairCheck { get; set; }

    [BinaryContent(Name = "TimeUntilSquadLogicCheck", NodeType = BinaryContentTypes.Attribute)]
    public object TimeUntilSquadLogicCheck { get; set; }

    [BinaryContent(Name = "IsThreatened", NodeType = BinaryContentTypes.Attribute)]
    public object IsThreatened { get; set; }

    [BinaryContent(Name = "MaxFleetSize", NodeType = BinaryContentTypes.Attribute)]
    public object MaxFleetSize { get; set; }

    [BinaryContent(Name = "MilitaryShipLimit", NodeType = BinaryContentTypes.Attribute)]
    public object MilitaryShipLimit { get; set; }

    [BinaryContent(Name = "CurrentStrengthLevel", NodeType = BinaryContentTypes.Node)]
    public CurrentStrengthLevel CurrentStrengthLevel { get; set; }

    [BinaryContent(Name = "DangerTrackedParticipant", NodeType = BinaryContentTypes.Node)]
    public DangerTrackedParticipant DangerTrackedParticipant { get; set; }

  }
}