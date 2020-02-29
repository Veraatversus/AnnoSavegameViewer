using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class UsedAmountList {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public UsedAmountListValue Value { get; set; }

  }
}