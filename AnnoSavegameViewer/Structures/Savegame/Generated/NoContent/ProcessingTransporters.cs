using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ProcessingTransporters {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<ProcessingTransportersList> ProcessingTransportersList { get; set; }

  }
}