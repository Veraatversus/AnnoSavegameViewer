namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class VariablesArrayData {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<VariablesArrayDataList> VariablesArrayDataList { get; set; }

  }
}