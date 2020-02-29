using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class PlannedSettlementsList {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public PlannedSettlementsListValue Value { get; set; }

  }
}