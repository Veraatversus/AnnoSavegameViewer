using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Rentable {

    [BinaryContent(Name = "Tenant", NodeType = BinaryContentTypes.Node)]
    public Tenant Tenant { get; set; }

  }
}