using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class RequiredHappinessRanges {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<RequiredHappinessRangesList> RequiredHappinessRangesList { get; set; }

  }
}