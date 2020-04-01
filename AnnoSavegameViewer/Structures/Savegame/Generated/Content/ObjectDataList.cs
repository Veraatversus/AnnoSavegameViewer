using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ObjectDataList {

    [BinaryContent(Name = "SettingsIndex", NodeType = BinaryContentTypes.Attribute)]
    public object SettingsIndex { get; set; }

  }
}