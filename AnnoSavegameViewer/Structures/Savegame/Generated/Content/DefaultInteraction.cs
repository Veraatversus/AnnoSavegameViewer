using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class DefaultInteraction {

    [BinaryContent(Name = "AutoClose", NodeType = BinaryContentTypes.Attribute)]
    public object AutoClose { get; set; }

  }
}