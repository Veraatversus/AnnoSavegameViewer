using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Purpose {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public PurposeValue Value { get; set; }

  }
}