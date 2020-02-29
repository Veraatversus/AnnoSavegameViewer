using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Attackable {

    #region Public Properties

    [BinaryContent(Name = "LastAttackerID", NodeType = BinaryContentTypes.Attribute)]
    public object LastAttackerID { get; set; }

    [BinaryContent(Name = "IslandWarFlagID", NodeType = BinaryContentTypes.Attribute)]
    public object IslandWarFlagID { get; set; }

    [BinaryContent(Name = "ExplosionCheckThreshold", NodeType = BinaryContentTypes.Attribute)]
    public object ExplosionCheckThreshold { get; set; }

    [BinaryContent(Name = "LastDamageTime", NodeType = BinaryContentTypes.Attribute)]
    public object LastDamageTime { get; set; }

    [BinaryContent(Name = "LastDamageByAttacker", NodeType = BinaryContentTypes.Attribute)]
    public object LastDamageByAttacker { get; set; }

    [BinaryContent(Name = "HealTickRemainder", NodeType = BinaryContentTypes.Attribute)]
    public object HealTickRemainder { get; set; }

    [BinaryContent(Name = "RemainderDamage", NodeType = BinaryContentTypes.Attribute)]
    public object RemainderDamage { get; set; }

    [BinaryContent(Name = "IsDead", NodeType = BinaryContentTypes.Attribute)]
    public object IsDead { get; set; }

    [BinaryContent(Name = "HitPoints", NodeType = BinaryContentTypes.Attribute)]
    public object HitPoints { get; set; }

    [BinaryContent(Name = "LastDamageOwner", NodeType = BinaryContentTypes.Node)]
    public LastDamageOwner LastDamageOwner { get; set; }

    [BinaryContent(Name = "LastOvertakeDamageDealerOwner", NodeType = BinaryContentTypes.Node)]
    public LastOvertakeDamageDealerOwner LastOvertakeDamageDealerOwner { get; set; }

    [BinaryContent(Name = "StatusEffects", NodeType = BinaryContentTypes.Node)]
    public StatusEffects StatusEffects { get; set; }

    [BinaryContent(Name = "ManagedAttackersByRange", NodeType = BinaryContentTypes.Node)]
    public ManagedAttackersByRange ManagedAttackersByRange { get; set; }

    #endregion Public Properties
  }
}