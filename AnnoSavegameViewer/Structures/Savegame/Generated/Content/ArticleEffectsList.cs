using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ArticleEffectsList {

    [BinaryContent(Name = "Value", NodeType = BinaryContentTypes.Attribute)]
    public object Value { get; set; }

    [BinaryContent(Name = "TriggeredByPropaganda", NodeType = BinaryContentTypes.Attribute)]
    public object TriggeredByPropaganda { get; set; }

    [BinaryContent(Name = "Context", NodeType = BinaryContentTypes.Attribute)]
    public object Context { get; set; }

    [BinaryContent(Name = "Effect", NodeType = BinaryContentTypes.Node)]
    public Effect Effect { get; set; }

  }
}