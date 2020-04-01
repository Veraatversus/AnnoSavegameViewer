using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ItemContainer {

    [BinaryContent(Name = "KamikazeDecal", NodeType = BinaryContentTypes.Attribute)]
    public object KamikazeDecal { get; set; }

    [BinaryContent(Name = "SlotContainer", NodeType = BinaryContentTypes.Node)]
    public SlotContainer SlotContainer { get; set; }

    [BinaryContent(Name = "SocketContainer", NodeType = BinaryContentTypes.Node)]
    public SocketContainer SocketContainer { get; set; }

  }
}