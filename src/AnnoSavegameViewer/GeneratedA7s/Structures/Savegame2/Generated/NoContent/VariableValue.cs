namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class VariableValue {

    [BinaryContent(Name = "FloatValue", NodeType = BinaryContentTypes.Node)]
    public FloatValue FloatValue { get; set; }

    [BinaryContent(Name = "Variable", NodeType = BinaryContentTypes.Node)]
    public VariableValueVariable Variable { get; set; }

  }
}