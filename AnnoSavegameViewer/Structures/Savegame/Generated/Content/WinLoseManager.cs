namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class WinLoseManager {

    [BinaryContent(Name = "LoseConditionsCount", NodeType = BinaryContentTypes.Attribute)]
    public object LoseConditionsCount { get; set; }

    [BinaryContent(Name = "ParticipantsWinLoseData", NodeType = BinaryContentTypes.Node)]
    public ParticipantsWinLoseData ParticipantsWinLoseData { get; set; }

    [BinaryContent(Name = "WinLoseCondition", NodeType = BinaryContentTypes.Node)]
    public List<WinLoseCondition> WinLoseCondition { get; set; }

  }
}