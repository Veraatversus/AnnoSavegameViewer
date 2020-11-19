namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class FogOfWarObjectsList {

    [BinaryContent(Name = "Object", NodeType = BinaryContentTypes.Node)]
    public Object Object { get; set; }

    [BinaryContent(Name = "Participant", NodeType = BinaryContentTypes.Node)]
    public Participant Participant { get; set; }

    [BinaryContent(Name = "DiscoverRadius", NodeType = BinaryContentTypes.Node)]
    public DiscoverRadius DiscoverRadius { get; set; }

  }
}