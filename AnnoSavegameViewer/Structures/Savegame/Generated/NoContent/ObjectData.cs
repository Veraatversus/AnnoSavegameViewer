using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ObjectData {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public ObjectDataList ObjectDataList { get; set; }

  }
}