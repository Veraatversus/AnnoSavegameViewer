using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class VariablesArray {

    [BinaryContent(Name = "Data", NodeType = BinaryContentTypes.Node)]
    public VariablesArrayData Data { get; set; }

  }
}