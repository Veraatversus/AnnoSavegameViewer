namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class VariablesArray {

    [BinaryContent(Name = "Data", NodeType = BinaryContentTypes.Node)]
    public VariablesArrayData Data { get; set; }

  }
}