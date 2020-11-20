namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class BuildingWithEffectActive {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<BuildingWithEffectActiveList> BuildingWithEffectActiveList { get; set; }

  }
}