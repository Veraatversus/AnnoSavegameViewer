using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class AreaFestivalManager {

    #region Public Properties

    [BinaryContent(Name = "nextTick", NodeType = BinaryContentTypes.Attribute)]
    public object NextTick { get; set; }

    [BinaryContent(Name = "poolThreshold", NodeType = BinaryContentTypes.Attribute)]
    public object PoolThreshold { get; set; }

    [BinaryContent(Name = "poolVal", NodeType = BinaryContentTypes.Attribute)]
    public object PoolVal { get; set; }

    [BinaryContent(Name = "isActive", NodeType = BinaryContentTypes.Attribute)]
    public object IsActive { get; set; }

    [BinaryContent(Name = "attractivenessBonus", NodeType = BinaryContentTypes.Attribute)]
    public object AttractivenessBonus { get; set; }

    [BinaryContent(Name = "activeType", NodeType = BinaryContentTypes.Node)]
    public AreaFestivalManagerActiveType ActiveType { get; set; }

    [BinaryContent(Name = "activeEffects", NodeType = BinaryContentTypes.Node)]
    public ActiveEffects ActiveEffects { get; set; }

    #endregion Public Properties
  }
}