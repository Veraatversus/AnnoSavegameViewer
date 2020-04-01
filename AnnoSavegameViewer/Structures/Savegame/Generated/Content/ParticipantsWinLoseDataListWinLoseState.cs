using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ParticipantsWinLoseDataListWinLoseState {

    [BinaryContent(Name = "WinLoseState", NodeType = BinaryContentTypes.Attribute)]
    public object WinLoseState { get; set; }

  }
}