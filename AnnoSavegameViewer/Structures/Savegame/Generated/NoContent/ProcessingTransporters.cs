namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class ProcessingTransporters {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<ProcessingTransportersList> ProcessingTransportersList { get; set; }

  }
}