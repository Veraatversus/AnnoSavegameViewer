namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class AreaTransporterManager {

    [BinaryContent(Name = "Transporters", NodeType = BinaryContentTypes.Node)]
    public AreaTransporterManagerTransporters Transporters { get; set; }

    [BinaryContent(Name = "UnsentTransporters", NodeType = BinaryContentTypes.Node)]
    public UnsentTransporters UnsentTransporters { get; set; }

  }
}