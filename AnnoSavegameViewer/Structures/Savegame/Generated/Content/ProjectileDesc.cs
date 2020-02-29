using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ProjectileDesc {

    [BinaryContent(Name = "OwnerID", NodeType = BinaryContentTypes.Attribute)]
    public object OwnerID { get; set; }

    [BinaryContent(Name = "TargetID", NodeType = BinaryContentTypes.Attribute)]
    public object TargetID { get; set; }

    [BinaryContent(Name = "HitType", NodeType = BinaryContentTypes.Node)]
    public HitType HitType { get; set; }

    [BinaryContent(Name = "AdditionalStatusEffects", NodeType = BinaryContentTypes.Node)]
    public AdditionalStatusEffects AdditionalStatusEffects { get; set; }

  }
}