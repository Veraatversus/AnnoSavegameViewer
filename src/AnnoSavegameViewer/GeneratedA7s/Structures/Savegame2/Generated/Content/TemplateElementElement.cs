namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class TemplateElementElement {

    [BinaryContent(Name = "Position", NodeType = BinaryContentTypes.Attribute)]
    public object Position { get; set; }

    [BinaryContent(Name = "MapFilePath", NodeType = BinaryContentTypes.Attribute)]
    public object MapFilePath { get; set; }

    [BinaryContent(Name = "Rotation90", NodeType = BinaryContentTypes.Attribute)]
    public object Rotation90 { get; set; }

    [BinaryContent(Name = "IslandLabel", NodeType = BinaryContentTypes.Attribute)]
    public object IslandLabel { get; set; }

    [BinaryContent(Name = "FertilityGuids", NodeType = BinaryContentTypes.Attribute)]
    public object FertilityGuids { get; set; }

    [BinaryContent(Name = "RandomizeFertilities", NodeType = BinaryContentTypes.Attribute)]
    public object RandomizeFertilities { get; set; }

    [BinaryContent(Name = "MineSlotMapping", NodeType = BinaryContentTypes.Node)]
    public MineSlotMapping MineSlotMapping { get; set; }

    [BinaryContent(Name = "RandomIslandConfig", NodeType = BinaryContentTypes.Node)]
    public RandomIslandConfig RandomIslandConfig { get; set; }

  }
}