namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class Projectile {

    [BinaryContent(Name = "LaunchRotationWS", NodeType = BinaryContentTypes.Attribute)]
    public object LaunchRotationWS { get; set; }

    [BinaryContent(Name = "ProjectileState", NodeType = BinaryContentTypes.Attribute)]
    public object ProjectileState { get; set; }

    [BinaryContent(Name = "HitTimeout", NodeType = BinaryContentTypes.Attribute)]
    public object HitTimeout { get; set; }

    [BinaryContent(Name = "Velocity", NodeType = BinaryContentTypes.Attribute)]
    public object Velocity { get; set; }

    [BinaryContent(Name = "LaunchTime", NodeType = BinaryContentTypes.Attribute)]
    public object LaunchTime { get; set; }

    [BinaryContent(Name = "ProjectileDesc", NodeType = BinaryContentTypes.Node)]
    public ProjectileDesc ProjectileDesc { get; set; }

  }
}