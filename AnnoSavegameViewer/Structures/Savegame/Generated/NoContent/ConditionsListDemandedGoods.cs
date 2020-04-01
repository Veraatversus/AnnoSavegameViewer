using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ConditionsListDemandedGoods {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public ConditionsListDemandedGoodsList ConditionsListDemandedGoodsList { get; set; }

  }
}