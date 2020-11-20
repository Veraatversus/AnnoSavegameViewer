namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class MessageStatesList {

    [BinaryContent(Name = "ForbidBefore", NodeType = BinaryContentTypes.Attribute)]
    public object ForbidBefore { get; set; }

    [BinaryContent(Name = "Executed", NodeType = BinaryContentTypes.Attribute)]
    public object Executed { get; set; }

    [BinaryContent(Name = "TriggerCounts", NodeType = BinaryContentTypes.Attribute)]
    public object TriggerCounts { get; set; }

  }
}