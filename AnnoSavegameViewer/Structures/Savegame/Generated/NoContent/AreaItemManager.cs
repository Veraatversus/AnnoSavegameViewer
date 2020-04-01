using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class AreaItemManager {

    [BinaryContent(Name = "AreaSlotContainer", NodeType = BinaryContentTypes.Node)]
    public AreaSlotContainer AreaSlotContainer { get; set; }

  }
}