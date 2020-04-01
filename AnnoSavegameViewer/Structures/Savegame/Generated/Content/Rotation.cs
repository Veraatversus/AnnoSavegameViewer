using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Rotation {

    [BinaryContent(Name = "Rotation", NodeType = BinaryContentTypes.Attribute)]
    public object RotationItem { get; set; }

  }
}