using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class BalanceListList {

    [BinaryContent(Name = "NetBalance", NodeType = BinaryContentTypes.Attribute)]
    public object NetBalance { get; set; }

    [BinaryContent(Name = "ProvidedFor", NodeType = BinaryContentTypes.Node)]
    public ProvidedFor ProvidedFor { get; set; }

    [BinaryContent(Name = "ProvidedBy", NodeType = BinaryContentTypes.Node)]
    public ProvidedBy ProvidedBy { get; set; }

  }
}