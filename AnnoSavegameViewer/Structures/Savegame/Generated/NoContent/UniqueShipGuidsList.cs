using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class UniqueShipGuidsList {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public UniqueShipGuidsListValue Value { get; set; }

  }
}