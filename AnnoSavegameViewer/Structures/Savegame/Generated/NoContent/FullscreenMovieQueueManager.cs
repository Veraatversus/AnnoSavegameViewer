using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class FullscreenMovieQueueManager {

    [BinaryContent(Name = "MovieQueue", NodeType = BinaryContentTypes.Node)]
    public MovieQueue MovieQueue { get; set; }

  }
}