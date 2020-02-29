using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class OpenLayout {

    [BinaryContent(Name = "RailroadOrnamentals", NodeType = BinaryContentTypes.Node)]
    public RailroadOrnamentals RailroadOrnamentals { get; set; }

  }
}