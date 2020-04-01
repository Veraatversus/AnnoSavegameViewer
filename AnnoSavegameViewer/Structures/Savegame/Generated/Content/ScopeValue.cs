using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ScopeValue {

    [BinaryContent(Name = "id", NodeType = BinaryContentTypes.Attribute)]
    public object Id { get; set; }

  }
}