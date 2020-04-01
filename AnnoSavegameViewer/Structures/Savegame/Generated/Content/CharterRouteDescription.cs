using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class CharterRouteDescription {

    [BinaryContent(Name = "SourceArea", NodeType = BinaryContentTypes.Attribute)]
    public object SourceArea { get; set; }

    [BinaryContent(Name = "TargetArea", NodeType = BinaryContentTypes.Attribute)]
    public object TargetArea { get; set; }

  }
}