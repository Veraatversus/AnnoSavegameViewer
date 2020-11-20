namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class FullscreenMovieQueueManager {

    [BinaryContent(Name = "MovieQueue", NodeType = BinaryContentTypes.Node)]
    public MovieQueue MovieQueue { get; set; }

  }
}