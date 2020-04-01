using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class VariablesArray {

    [BinaryContent(Name = "Data", NodeType = BinaryContentTypes.Node)]
    public VariablesArrayData Data { get; set; }

  }
}