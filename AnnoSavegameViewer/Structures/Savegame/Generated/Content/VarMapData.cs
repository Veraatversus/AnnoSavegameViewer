using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class VarMapData {

    [BinaryContent(Name = "SparseEnabled", NodeType = BinaryContentTypes.Attribute)]
    public object SparseEnabled { get; set; }

    [BinaryContent(Name = "x", NodeType = BinaryContentTypes.Attribute)]
    public object X { get; set; }

    [BinaryContent(Name = "y", NodeType = BinaryContentTypes.Attribute)]
    public object Y { get; set; }

    [BinaryContent(Name = "block", NodeType = BinaryContentTypes.Node)]
    public List<Block> Block { get; set; }

  }
}