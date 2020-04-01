using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class RequirementsList {

    [BinaryContent(Name = "Amount", NodeType = BinaryContentTypes.Attribute)]
    public object Amount { get; set; }

    [BinaryContent(Name = "Region", NodeType = BinaryContentTypes.Node)]
    public Region Region { get; set; }

    [BinaryContent(Name = "CivLevel", NodeType = BinaryContentTypes.Node)]
    public CivLevel CivLevel { get; set; }

  }
}