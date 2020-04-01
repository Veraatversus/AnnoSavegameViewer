using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class AreaTransporterManagerTransportersList {

    [BinaryContent(Name = "TransporterID", NodeType = BinaryContentTypes.Node)]
    public TransporterID TransporterID { get; set; }

  }
}