namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class VirtualSlotsList {

    [BinaryContent(Name = "size", NodeType = BinaryContentTypes.Attribute)]
    public object Size { get; set; }

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public VirtualSlotsListList VirtualSlotsListList { get; set; }

  }
}