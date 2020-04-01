using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class AttackerDataListList {

    [BinaryContent(Name = "AttackerSettingsIndex", NodeType = BinaryContentTypes.Attribute)]
    public object AttackerSettingsIndex { get; set; }

    [BinaryContent(Name = "AttackerSpawnTime", NodeType = BinaryContentTypes.Attribute)]
    public object AttackerSpawnTime { get; set; }

  }
}