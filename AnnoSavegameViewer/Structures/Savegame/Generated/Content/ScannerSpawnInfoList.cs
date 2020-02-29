using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ScannerSpawnInfoList {

    [BinaryContent(Name = "GUID", NodeType = BinaryContentTypes.Attribute)]
    public object GUID { get; set; }

    [BinaryContent(Name = "Amount", NodeType = BinaryContentTypes.Attribute)]
    public object Amount { get; set; }

    [BinaryContent(Name = "CargoGUIDList", NodeType = BinaryContentTypes.Node)]
    public ScannerSpawnInfoListCargoGUIDList CargoGUIDList { get; set; }

    [BinaryContent(Name = "Owner", NodeType = BinaryContentTypes.Node)]
    public ScannerSpawnInfoListOwner Owner { get; set; }

    [BinaryContent(Name = "VisualOwner", NodeType = BinaryContentTypes.Node)]
    public ScannerSpawnInfoListVisualOwner VisualOwner { get; set; }

  }
}