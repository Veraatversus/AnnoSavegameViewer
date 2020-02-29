using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class DiplomacyStatesList {

    [BinaryContent(Name = "State", NodeType = BinaryContentTypes.Node)]
    public State State { get; set; }

  }
}