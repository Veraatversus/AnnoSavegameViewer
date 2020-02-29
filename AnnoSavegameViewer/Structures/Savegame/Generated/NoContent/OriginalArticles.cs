using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class OriginalArticles {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<OriginalArticlesList> OriginalArticlesList { get; set; }

  }
}