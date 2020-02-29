using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ToolOneManager {

    [BinaryContent(Name = "VariablesArray", NodeType = BinaryContentTypes.Node)]
    public VariablesArray VariablesArray { get; set; }

  }
}