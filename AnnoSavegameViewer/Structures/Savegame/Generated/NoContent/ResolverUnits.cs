using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ResolverUnits {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<ResolverUnitsList> ResolverUnitsList { get; set; }

  }
}