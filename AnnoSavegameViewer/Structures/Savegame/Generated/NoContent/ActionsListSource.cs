using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ActionsListSource {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public ActionsListSourceValue Value { get; set; }

  }
}