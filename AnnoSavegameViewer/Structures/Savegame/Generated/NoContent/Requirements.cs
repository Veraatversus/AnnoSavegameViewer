using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Requirements {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public RequirementsList RequirementsList { get; set; }

  }
}