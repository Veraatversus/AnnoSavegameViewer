using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ResourceSatisfaction {

    [BinaryContent(Name = "HappinessFactor", NodeType = BinaryContentTypes.Attribute)]
    public object HappinessFactor { get; set; }

    [BinaryContent(Name = "CrisisShareAmount", NodeType = BinaryContentTypes.Attribute)]
    public object CrisisShareAmount { get; set; }

    [BinaryContent(Name = "LastRiotTriggered", NodeType = BinaryContentTypes.Attribute)]
    public object LastRiotTriggered { get; set; }

    [BinaryContent(Name = "CurCrisisStart", NodeType = BinaryContentTypes.Attribute)]
    public object CurCrisisStart { get; set; }

    [BinaryContent(Name = "LastCrisisEnd", NodeType = BinaryContentTypes.Attribute)]
    public object LastCrisisEnd { get; set; }

    [BinaryContent(Name = "CrisisSeverity", NodeType = BinaryContentTypes.Attribute)]
    public object CrisisSeverity { get; set; }

    [BinaryContent(Name = "CrisisSeverityS", NodeType = BinaryContentTypes.Attribute)]
    public object CrisisSeverityS { get; set; }

    [BinaryContent(Name = "StableTradedTrade", NodeType = BinaryContentTypes.Node)]
    public StableTradedTrade StableTradedTrade { get; set; }

    [BinaryContent(Name = "StableUnstableTrade", NodeType = BinaryContentTypes.Node)]
    public StableUnstableTrade StableUnstableTrade { get; set; }

    [BinaryContent(Name = "ConnectedIslands", NodeType = BinaryContentTypes.Node)]
    public ConnectedIslands ConnectedIslands { get; set; }

  }
}