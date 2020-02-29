using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class LastRequesterBudget {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public LastRequesterBudgetValue Value { get; set; }

  }
}