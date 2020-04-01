using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Pirate {

    [BinaryContent(Name = "ChaseRange", NodeType = BinaryContentTypes.Attribute)]
    public object ChaseRange { get; set; }

    [BinaryContent(Name = "UsesEntirePlayableArea", NodeType = BinaryContentTypes.Attribute)]
    public object UsesEntirePlayableArea { get; set; }

    [BinaryContent(Name = "ComebackAt", NodeType = BinaryContentTypes.Attribute)]
    public object ComebackAt { get; set; }

    [BinaryContent(Name = "OfferCeasefireAt", NodeType = BinaryContentTypes.Attribute)]
    public object OfferCeasefireAt { get; set; }

    [BinaryContent(Name = "ComebackQuestIDs", NodeType = BinaryContentTypes.Attribute)]
    public object ComebackQuestIDs { get; set; }

    [BinaryContent(Name = "AreaOfActivity", NodeType = BinaryContentTypes.Node)]
    public AreaOfActivity AreaOfActivity { get; set; }

    [BinaryContent(Name = "Kontor", NodeType = BinaryContentTypes.Node)]
    public Kontor Kontor { get; set; }

  }
}