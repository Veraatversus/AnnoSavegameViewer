using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ReplacementArticles {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<ReplacementArticlesList> ReplacementArticlesList { get; set; }

  }
}