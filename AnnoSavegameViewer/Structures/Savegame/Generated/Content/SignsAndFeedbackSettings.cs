using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class SignsAndFeedbackSettings {

    [BinaryContent(Name = "HideOnMinimap", NodeType = BinaryContentTypes.Attribute)]
    public object HideOnMinimap { get; set; }

    [BinaryContent(Name = "UseQuestOutlines", NodeType = BinaryContentTypes.Attribute)]
    public object UseQuestOutlines { get; set; }

    [BinaryContent(Name = "MinimapToken", NodeType = BinaryContentTypes.Attribute)]
    public object MinimapToken { get; set; }

    [BinaryContent(Name = "Infolayer", NodeType = BinaryContentTypes.Attribute)]
    public object Infolayer { get; set; }

  }
}