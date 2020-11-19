namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class PropagandaChancesList {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Attribute)]
    public List<object> None { get; set; }

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public PropagandaChancesListValue Value { get; set; }

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<PropagandaChancesListList> PropagandaChancesListList { get; set; }

  }
}