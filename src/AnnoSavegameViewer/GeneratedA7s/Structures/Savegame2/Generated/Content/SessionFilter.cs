namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class SessionFilter {

    [BinaryContent(Name = "SessionGUIDs", NodeType = BinaryContentTypes.Attribute)]
    public object SessionGUIDs { get; set; }

  }
}