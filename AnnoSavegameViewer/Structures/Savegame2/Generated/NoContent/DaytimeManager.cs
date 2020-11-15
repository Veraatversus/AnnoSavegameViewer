namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class DaytimeManager {

    [BinaryContent(Name = "DaytimeSetting", NodeType = BinaryContentTypes.Node)]
    public DaytimeSetting DaytimeSetting { get; set; }

  }
}