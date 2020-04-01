using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class AreaFestivalManager {

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
    public AreaFestivalManagerActiveEffects ActiveEffects { get; set; }

  }
}