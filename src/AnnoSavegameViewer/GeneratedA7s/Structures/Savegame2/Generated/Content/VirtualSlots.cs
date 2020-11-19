namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class VirtualSlots {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Attribute)]
    public object None { get; set; }

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public VirtualSlotsList VirtualSlotsList { get; set; }

  }
}