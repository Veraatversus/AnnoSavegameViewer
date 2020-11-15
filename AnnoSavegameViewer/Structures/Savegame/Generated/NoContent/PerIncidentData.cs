namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class PerIncidentData {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<PerIncidentDataList> PerIncidentDataList { get; set; }

  }
}