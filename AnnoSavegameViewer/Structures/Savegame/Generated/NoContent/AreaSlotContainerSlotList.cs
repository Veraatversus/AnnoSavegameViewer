using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class AreaSlotContainerSlotList {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<AreaSlotContainerSlotListList> AreaSlotContainerSlotListList { get; set; }

  }
}