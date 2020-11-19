namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class MetaExpeditionUser {

    [BinaryContent(Name = "nextExpeditionSlotTime", NodeType = BinaryContentTypes.Attribute)]
    public object NextExpeditionSlotTime { get; set; }

    [BinaryContent(Name = "expeditionOverviewEntered", NodeType = BinaryContentTypes.Attribute)]
    public object ExpeditionOverviewEntered { get; set; }

    [BinaryContent(Name = "expeditions", NodeType = BinaryContentTypes.Node)]
    public Expeditions Expeditions { get; set; }

    [BinaryContent(Name = "expeditionSlots", NodeType = BinaryContentTypes.Node)]
    public ExpeditionSlots ExpeditionSlots { get; set; }

  }
}