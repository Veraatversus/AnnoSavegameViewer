using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class BonusIncidentChanceList {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public BonusIncidentChanceListValue Value { get; set; }

  }
}