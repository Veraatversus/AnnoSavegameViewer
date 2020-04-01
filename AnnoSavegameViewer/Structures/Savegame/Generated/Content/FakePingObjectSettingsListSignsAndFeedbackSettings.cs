using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class FakePingObjectSettingsListSignsAndFeedbackSettings {

    [BinaryContent(Name = "MinimapToken", NodeType = BinaryContentTypes.Attribute)]
    public object MinimapToken { get; set; }

    [BinaryContent(Name = "Infolayer", NodeType = BinaryContentTypes.Attribute)]
    public object Infolayer { get; set; }

  }
}