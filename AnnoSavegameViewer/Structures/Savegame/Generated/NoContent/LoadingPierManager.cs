using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class LoadingPierManager {

    [BinaryContent(Name = "Harbors", NodeType = BinaryContentTypes.Node)]
    public Harbors Harbors { get; set; }

  }
}