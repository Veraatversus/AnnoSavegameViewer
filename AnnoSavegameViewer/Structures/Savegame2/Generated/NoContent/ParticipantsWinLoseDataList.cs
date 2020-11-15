namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class ParticipantsWinLoseDataList {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public ParticipantsWinLoseDataListValue Value { get; set; }

    [BinaryContent(Name = "WinLoseType", NodeType = BinaryContentTypes.Node)]
    public WinLoseType WinLoseType { get; set; }

    [BinaryContent(Name = "WinLoseState", NodeType = BinaryContentTypes.Node)]
    public ParticipantsWinLoseDataListWinLoseState WinLoseState { get; set; }

    [BinaryContent(Name = "Winner", NodeType = BinaryContentTypes.Node)]
    public Winner Winner { get; set; }

  }
}