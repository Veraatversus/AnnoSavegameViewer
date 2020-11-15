namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class FogOfWarObjects {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<FogOfWarObjectsList> FogOfWarObjectsList { get; set; }

  }
}