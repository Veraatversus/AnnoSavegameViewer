using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class SpawnTypeInfo {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public SpawnTypeInfoList SpawnTypeInfoList { get; set; }

  }
}