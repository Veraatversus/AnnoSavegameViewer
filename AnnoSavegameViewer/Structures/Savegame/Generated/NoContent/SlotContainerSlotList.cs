using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class SlotContainerSlotList {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<SlotContainerSlotListList> SlotContainerSlotListList { get; set; }

  }
}