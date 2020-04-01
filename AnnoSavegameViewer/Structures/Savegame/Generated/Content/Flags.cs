using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Flags {

    [BinaryContent(Name = "flags", NodeType = BinaryContentTypes.Attribute)]
    public object FlagsItem { get; set; }

  }
}