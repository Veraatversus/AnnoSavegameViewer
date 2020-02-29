using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class WorkerInfo {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<WorkerInfoList> WorkerInfoList { get; set; }

  }
}