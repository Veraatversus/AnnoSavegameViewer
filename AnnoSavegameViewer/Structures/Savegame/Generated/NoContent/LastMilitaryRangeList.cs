using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class LastMilitaryRangeList {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public LastMilitaryRangeListValue Value { get; set; }

  }
}