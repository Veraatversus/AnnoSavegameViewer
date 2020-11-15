namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class ReplacementArticles {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<ReplacementArticlesList> ReplacementArticlesList { get; set; }

  }
}