using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class AreaHarbourPropManager {

    [BinaryContent(Name = "TileToPropIDs", NodeType = BinaryContentTypes.Node)]
    public TileToPropIDs TileToPropIDs { get; set; }

  }
}