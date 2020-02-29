using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class SlotPositions {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<SlotPositionsList> SlotPositionsList { get; set; }

  }
}