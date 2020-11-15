namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class Factors {

    [BinaryContent(Name = "base", NodeType = BinaryContentTypes.Attribute)]
    public object Base { get; set; }

    [BinaryContent(Name = "density", NodeType = BinaryContentTypes.Attribute)]
    public object Density { get; set; }

    [BinaryContent(Name = "productivity", NodeType = BinaryContentTypes.Attribute)]
    public object Productivity { get; set; }

    [BinaryContent(Name = "workingCondF", NodeType = BinaryContentTypes.Attribute)]
    public object WorkingCondF { get; set; }

    [BinaryContent(Name = "factoryHappiness", NodeType = BinaryContentTypes.Attribute)]
    public object FactoryHappiness { get; set; }

    [BinaryContent(Name = "residenceHappiness", NodeType = BinaryContentTypes.Attribute)]
    public object ResidenceHappiness { get; set; }

    [BinaryContent(Name = "workingCondR", NodeType = BinaryContentTypes.Attribute)]
    public object WorkingCondR { get; set; }

    [BinaryContent(Name = "satisfaction", NodeType = BinaryContentTypes.Attribute)]
    public object Satisfaction { get; set; }

    [BinaryContent(Name = "heatChance", NodeType = BinaryContentTypes.Attribute)]
    public object HeatChance { get; set; }
  }
}