using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class AreaSlotContainerSlotListList {

    [BinaryContent(Name = "Stack", NodeType = BinaryContentTypes.Node)]
    public AreaSlotContainerSlotListListStack Stack { get; set; }

  }
}