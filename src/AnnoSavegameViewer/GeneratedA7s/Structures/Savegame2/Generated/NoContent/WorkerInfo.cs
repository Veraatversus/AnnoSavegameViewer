namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class WorkerInfo {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<WorkerInfoList> WorkerInfoList { get; set; }

  }
}