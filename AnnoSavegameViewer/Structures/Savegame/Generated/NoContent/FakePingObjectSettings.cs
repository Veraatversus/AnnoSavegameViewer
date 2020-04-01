using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class FakePingObjectSettings {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public FakePingObjectSettingsList FakePingObjectSettingsList { get; set; }

  }
}