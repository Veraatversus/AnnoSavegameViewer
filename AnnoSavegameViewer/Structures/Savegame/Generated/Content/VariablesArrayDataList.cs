namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class VariablesArrayDataList {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Attribute)]
    public List<object> None { get; set; }

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public VariablesArrayDataListValue Value { get; set; }

  }
}