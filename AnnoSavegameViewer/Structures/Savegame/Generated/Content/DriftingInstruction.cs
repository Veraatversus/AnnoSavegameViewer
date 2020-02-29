using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class DriftingInstruction {

    [BinaryContent(Name = "DriftingInstruction", NodeType = BinaryContentTypes.Attribute)]
    public object DriftingInstructionItem { get; set; }

  }
}