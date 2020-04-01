using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class AdditionalAreaEffectsListList {

    [BinaryContent(Name = "distance", NodeType = BinaryContentTypes.Attribute)]
    public object Distance { get; set; }

    [BinaryContent(Name = "targetArea", NodeType = BinaryContentTypes.Attribute)]
    public object TargetArea { get; set; }

    [BinaryContent(Name = "effect", NodeType = BinaryContentTypes.Attribute)]
    public object Effect { get; set; }

    [BinaryContent(Name = "scope", NodeType = BinaryContentTypes.Node)]
    public AdditionalAreaEffectsListListScope Scope { get; set; }

    [BinaryContent(Name = "targetParticipant", NodeType = BinaryContentTypes.Node)]
    public TargetParticipant TargetParticipant { get; set; }

    [BinaryContent(Name = "source", NodeType = BinaryContentTypes.Node)]
    public AdditionalAreaEffectsListListSource Source { get; set; }

    [BinaryContent(Name = "distanceSource", NodeType = BinaryContentTypes.Node)]
    public DistanceSource DistanceSource { get; set; }

  }
}