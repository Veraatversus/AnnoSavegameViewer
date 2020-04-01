using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class CoastLinePointsList {

    [BinaryContent(Name = "pos", NodeType = BinaryContentTypes.Attribute)]
    public object Pos { get; set; }

    [BinaryContent(Name = "dir", NodeType = BinaryContentTypes.Attribute)]
    public object Dir { get; set; }

  }
}