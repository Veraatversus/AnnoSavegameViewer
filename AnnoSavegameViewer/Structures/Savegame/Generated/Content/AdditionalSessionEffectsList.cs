namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class AdditionalSessionEffectsList {

    [BinaryContent(Name = "targetArea", NodeType = BinaryContentTypes.Attribute)]
    public object TargetArea { get; set; }

    [BinaryContent(Name = "effect", NodeType = BinaryContentTypes.Attribute)]
    public object Effect { get; set; }

    [BinaryContent(Name = "scope", NodeType = BinaryContentTypes.Node)]
    public AdditionalSessionEffectsListScope Scope { get; set; }

    [BinaryContent(Name = "targetParticipant", NodeType = BinaryContentTypes.Node)]
    public AdditionalSessionEffectsListTargetParticipant TargetParticipant { get; set; }

    [BinaryContent(Name = "source", NodeType = BinaryContentTypes.Node)]
    public AdditionalSessionEffectsListSource Source { get; set; }

    [BinaryContent(Name = "distanceSource", NodeType = BinaryContentTypes.Node)]
    public AdditionalSessionEffectsListDistanceSource DistanceSource { get; set; }
  }
}