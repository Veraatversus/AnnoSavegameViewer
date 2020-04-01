using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Rentable {

    [BinaryContent(Name = "Tenant", NodeType = BinaryContentTypes.Node)]
    public Tenant Tenant { get; set; }

  }
}