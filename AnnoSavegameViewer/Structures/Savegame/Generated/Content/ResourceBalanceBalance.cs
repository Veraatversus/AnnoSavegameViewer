using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ResourceBalanceBalance {

    [BinaryContent(Name = "TaxBalance", NodeType = BinaryContentTypes.Attribute)]
    public object TaxBalance { get; set; }

    [BinaryContent(Name = "CivLevelInfos", NodeType = BinaryContentTypes.Node)]
    public ResourceBalanceBalanceCivLevelInfos CivLevelInfos { get; set; }

    [BinaryContent(Name = "EndProductNeeds", NodeType = BinaryContentTypes.Node)]
    public ResourceBalanceBalanceEndProductNeeds EndProductNeeds { get; set; }

    [BinaryContent(Name = "NonConsumedNeeds", NodeType = BinaryContentTypes.Node)]
    public ResourceBalanceBalanceNonConsumedNeeds NonConsumedNeeds { get; set; }

    [BinaryContent(Name = "AccumulatedNeeds", NodeType = BinaryContentTypes.Node)]
    public ResourceBalanceBalanceAccumulatedNeeds AccumulatedNeeds { get; set; }

    [BinaryContent(Name = "ProductInputs", NodeType = BinaryContentTypes.Node)]
    public ResourceBalanceBalanceProductInputs ProductInputs { get; set; }

    [BinaryContent(Name = "ProductOutputs", NodeType = BinaryContentTypes.Node)]
    public ResourceBalanceBalanceProductOutputs ProductOutputs { get; set; }

    [BinaryContent(Name = "ProductDeltasReal", NodeType = BinaryContentTypes.Node)]
    public ResourceBalanceBalanceProductDeltasReal ProductDeltasReal { get; set; }

    [BinaryContent(Name = "MoneyBalance", NodeType = BinaryContentTypes.Node)]
    public ResourceBalanceBalanceMoneyBalance MoneyBalance { get; set; }

  }
}