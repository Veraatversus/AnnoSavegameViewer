using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class HappinessDataOwner {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public HappinessDataOwnerValue Value { get; set; }

  }
}