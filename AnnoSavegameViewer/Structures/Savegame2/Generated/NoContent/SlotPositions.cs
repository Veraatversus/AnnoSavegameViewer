namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class SlotPositions {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<SlotPositionsList> SlotPositionsList { get; set; }

  }
}