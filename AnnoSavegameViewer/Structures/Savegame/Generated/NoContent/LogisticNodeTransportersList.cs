using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class LogisticNodeTransportersList {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<LogisticNodeTransportersListList> LogisticNodeTransportersListList { get; set; }

  }
}