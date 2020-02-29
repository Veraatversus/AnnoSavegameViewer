using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class WinLoseCondition {

    [BinaryContent(Name = "ElementType", NodeType = BinaryContentTypes.Node)]
    public ElementType ElementType { get; set; }

    [BinaryContent(Name = "Owner", NodeType = BinaryContentTypes.Node)]
    public WinLoseConditionOwner Owner { get; set; }

  }
}