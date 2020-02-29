using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ArticleEffects {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<ArticleEffectsList> ArticleEffectsList { get; set; }

  }
}