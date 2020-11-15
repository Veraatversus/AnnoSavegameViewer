namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class ParticipantDataList {

    [BinaryContent(Name = "CurrentVolume", NodeType = BinaryContentTypes.Attribute)]
    public object CurrentVolume { get; set; }

    [BinaryContent(Name = "NewspaperCreateTimer", NodeType = BinaryContentTypes.Attribute)]
    public object NewspaperCreateTimer { get; set; }

    [BinaryContent(Name = "NewsTrackerCount", NodeType = BinaryContentTypes.Attribute)]
    public object NewsTrackerCount { get; set; }

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public ParticipantDataListValue Value { get; set; }

    [BinaryContent(Name = "Target", NodeType = BinaryContentTypes.Node)]
    public ParticipantDataListTarget Target { get; set; }

    [BinaryContent(Name = "Newspapers", NodeType = BinaryContentTypes.Node)]
    public Newspapers Newspapers { get; set; }

    [BinaryContent(Name = "NewspaperEvents", NodeType = BinaryContentTypes.Node)]
    public NewspaperEvents NewspaperEvents { get; set; }

    [BinaryContent(Name = "ArticleEffects", NodeType = BinaryContentTypes.Node)]
    public ArticleEffects ArticleEffects { get; set; }

    [BinaryContent(Name = "PriorityBonus", NodeType = BinaryContentTypes.Node)]
    public PriorityBonus PriorityBonus { get; set; }

    [BinaryContent(Name = "NewsTracker", NodeType = BinaryContentTypes.Node)]
    public List<NewsTracker> NewsTracker { get; set; }

  }
}