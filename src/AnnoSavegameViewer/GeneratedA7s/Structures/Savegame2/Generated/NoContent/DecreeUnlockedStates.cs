namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class DecreeUnlockedStates {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<DecreeUnlockedStatesList> DecreeUnlockedStatesList { get; set; }

  }
}