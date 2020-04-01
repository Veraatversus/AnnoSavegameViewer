using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class SignsAndFeedbackSettings {

    [BinaryContent(Name = "MinimapToken", NodeType = BinaryContentTypes.Attribute)]
    public object MinimapToken { get; set; }

    [BinaryContent(Name = "Infolayer", NodeType = BinaryContentTypes.Attribute)]
    public object Infolayer { get; set; }

    [BinaryContent(Name = "HideOnMinimap", NodeType = BinaryContentTypes.Attribute)]
    public object HideOnMinimap { get; set; }

    [BinaryContent(Name = "UseQuestOutlines", NodeType = BinaryContentTypes.Attribute)]
    public object UseQuestOutlines { get; set; }

    [BinaryContent(Name = "KeepHighlights", NodeType = BinaryContentTypes.Attribute)]
    public object KeepHighlights { get; set; }

  }
}