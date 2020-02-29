using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class LastAttackerList {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public LastAttackerListValue Value { get; set; }

  }
}