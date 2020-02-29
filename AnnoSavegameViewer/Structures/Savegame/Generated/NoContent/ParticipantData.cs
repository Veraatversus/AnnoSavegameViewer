using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ParticipantData {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<ParticipantDataList> ParticipantDataList { get; set; }

  }
}