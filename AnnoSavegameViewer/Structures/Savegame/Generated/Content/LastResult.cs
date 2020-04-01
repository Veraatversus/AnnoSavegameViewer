using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class LastResult {

    [BinaryContent(Name = "MoraleLeft", NodeType = BinaryContentTypes.Attribute)]
    public object MoraleLeft { get; set; }

    [BinaryContent(Name = "LastResult", NodeType = BinaryContentTypes.Node)]
    public LastResultLastResult lastResult { get; set; }

    [BinaryContent(Name = "Defender", NodeType = BinaryContentTypes.Node)]
    public Defender Defender { get; set; }

    [BinaryContent(Name = "Attackers", NodeType = BinaryContentTypes.Node)]
    public Attackers Attackers { get; set; }

    [BinaryContent(Name = "OriginalShareOwner", NodeType = BinaryContentTypes.Node)]
    public OriginalShareOwner OriginalShareOwner { get; set; }

  }
}