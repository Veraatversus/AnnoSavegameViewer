using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class VariablesArrayData {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<VariablesArrayDataList> VariablesArrayDataList { get; set; }

  }
}