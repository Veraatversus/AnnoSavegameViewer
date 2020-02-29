using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class CargoItems {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public CargoItemsList CargoItemsList { get; set; }

  }
}