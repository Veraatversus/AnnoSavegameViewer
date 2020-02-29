using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class FreeAreaproductivity {

    [BinaryContent(Name = "WorkerInfo", NodeType = BinaryContentTypes.Node)]
    public WorkerInfo WorkerInfo { get; set; }

  }
}