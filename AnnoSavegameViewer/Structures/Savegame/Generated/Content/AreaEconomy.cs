using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class AreaEconomy {

    [BinaryContent(Name = "happinessFactor", NodeType = BinaryContentTypes.Attribute)]
    public object HappinessFactor { get; set; }

    [BinaryContent(Name = "Storage", NodeType = BinaryContentTypes.Node)]
    public AreaEconomyStorage Storage { get; set; }

    [BinaryContent(Name = "Transporters", NodeType = BinaryContentTypes.Node)]
    public AreaEconomyTransporters Transporters { get; set; }

    [BinaryContent(Name = "EconomyModifiers", NodeType = BinaryContentTypes.Node)]
    public EconomyModifiers EconomyModifiers { get; set; }

    [BinaryContent(Name = "StorageTrends", NodeType = BinaryContentTypes.Node)]
    public StorageTrends StorageTrends { get; set; }

    [BinaryContent(Name = "pendingChanges", NodeType = BinaryContentTypes.Node)]
    public PendingChanges PendingChanges { get; set; }

    [BinaryContent(Name = "shareValueFluctuation", NodeType = BinaryContentTypes.Node)]
    public ShareValueFluctuation ShareValueFluctuation { get; set; }

  }
}