namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class OriginalArticles {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<OriginalArticlesList> OriginalArticlesList { get; set; }

  }
}