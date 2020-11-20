namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class Rentable {

    [BinaryContent(Name = "Tenant", NodeType = BinaryContentTypes.Node)]
    public Tenant Tenant { get; set; }

  }
}