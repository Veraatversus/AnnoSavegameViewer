namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using AnnoSavegameViewer.Structures.DataTypes;

  public class Nameable {

    [BinaryContent(Name = "VehicleTextGuid", NodeType = BinaryContentTypes.Attribute)]
    public DescriptionInt VehicleTextGuid { get; set; }

    [BinaryContent(Name = "VehicleTextIterator", NodeType = BinaryContentTypes.Attribute)]
    public object VehicleTextIterator { get; set; }

    [BinaryContent(Name = "VehicleName", NodeType = BinaryContentTypes.Attribute, Encoding = "UTF-16")]
    public string VehicleName { get; set; }

  }
}