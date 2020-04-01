using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class CurrentMinesList {

    [BinaryContent(Name = "pos", NodeType = BinaryContentTypes.Attribute)]
    public object Pos { get; set; }

    [BinaryContent(Name = "area", NodeType = BinaryContentTypes.Attribute)]
    public object Area { get; set; }

  }
}