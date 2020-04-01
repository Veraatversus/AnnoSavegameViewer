using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class VirtualSlots {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Attribute)]
    public object None { get; set; }

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public VirtualSlotsList VirtualSlotsList { get; set; }

  }
}