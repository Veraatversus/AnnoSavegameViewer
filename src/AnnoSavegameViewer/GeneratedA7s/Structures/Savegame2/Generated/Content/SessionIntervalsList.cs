namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class SessionIntervalsList {

    [BinaryContent(Name = "IntervalEnd", NodeType = BinaryContentTypes.Attribute)]
    public object IntervalEnd { get; set; }

    [BinaryContent(Name = "BonusChance", NodeType = BinaryContentTypes.Attribute)]
    public object BonusChance { get; set; }

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<SessionIntervalsListList> SessionIntervalsListList { get; set; }

  }
}