namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class ArticleEffects {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<ArticleEffectsList> ArticleEffectsList { get; set; }

  }
}