using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class LastKilledList {

    [BinaryContent(Name = "LastAttack", NodeType = BinaryContentTypes.Attribute)]
    public object LastAttack { get; set; }

    [BinaryContent(Name = "SecondLastAttack", NodeType = BinaryContentTypes.Attribute)]
    public object SecondLastAttack { get; set; }

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public LastKilledListValue Value { get; set; }

  }
}