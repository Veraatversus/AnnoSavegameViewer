using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class MilTakeOverData {

    [BinaryContent(Name = "LastAttackTime", NodeType = BinaryContentTypes.Attribute)]
    public object LastAttackTime { get; set; }

    [BinaryContent(Name = "WarMoraleOvertakeWarning", NodeType = BinaryContentTypes.Attribute)]
    public object WarMoraleOvertakeWarning { get; set; }

    [BinaryContent(Name = "WarMoraleOvertakeStart", NodeType = BinaryContentTypes.Attribute)]
    public object WarMoraleOvertakeStart { get; set; }

    [BinaryContent(Name = "WarMoraleOvertakeEnd", NodeType = BinaryContentTypes.Attribute)]
    public object WarMoraleOvertakeEnd { get; set; }

    [BinaryContent(Name = "WarMoraleOvertakeCalculated", NodeType = BinaryContentTypes.Attribute)]
    public object WarMoraleOvertakeCalculated { get; set; }

    [BinaryContent(Name = "MoralSubstracters", NodeType = BinaryContentTypes.Node)]
    public MoralSubstracters MoralSubstracters { get; set; }

    [BinaryContent(Name = "LastResult", NodeType = BinaryContentTypes.Node)]
    public LastResult LastResult { get; set; }

  }
}