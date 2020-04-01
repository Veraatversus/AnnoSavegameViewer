using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class FogsOfWarList {

    [BinaryContent(Name = "LastReHideTime", NodeType = BinaryContentTypes.Attribute)]
    public object LastReHideTime { get; set; }

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public FogsOfWarListValue Value { get; set; }

    [BinaryContent(Name = "DirtyPositions", NodeType = BinaryContentTypes.Node)]
    public DirtyPositions DirtyPositions { get; set; }

  }
}