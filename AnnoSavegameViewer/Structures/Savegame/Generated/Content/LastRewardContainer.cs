using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class LastRewardContainer {

    [BinaryContent(Name = "UnlimitedSlotCount", NodeType = BinaryContentTypes.Attribute)]
    public object UnlimitedSlotCount { get; set; }

    [BinaryContent(Name = "UnlimitedStack", NodeType = BinaryContentTypes.Attribute)]
    public object UnlimitedStack { get; set; }

    [BinaryContent(Name = "AreaID", NodeType = BinaryContentTypes.Attribute)]
    public object AreaID { get; set; }

    [BinaryContent(Name = "SlotList", NodeType = BinaryContentTypes.Node)]
    public SlotList SlotList { get; set; }

  }
}