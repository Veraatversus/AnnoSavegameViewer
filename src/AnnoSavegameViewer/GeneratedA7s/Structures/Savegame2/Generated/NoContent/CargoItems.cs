namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class CargoItems {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<CargoItemsList> CargoItemsList { get; set; }

  }
}