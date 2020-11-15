namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class ParticipantsWinLoseData {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<ParticipantsWinLoseDataList> ParticipantsWinLoseDataList { get; set; }

  }
}