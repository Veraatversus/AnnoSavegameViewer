using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class DestroySpawnInfoList {

    [BinaryContent(Name = "GUID", NodeType = BinaryContentTypes.Attribute)]
    public object GUID { get; set; }

    [BinaryContent(Name = "Amount", NodeType = BinaryContentTypes.Attribute)]
    public object Amount { get; set; }

    [BinaryContent(Name = "CargoGUIDList", NodeType = BinaryContentTypes.Node)]
    public DestroySpawnInfoListCargoGUIDList CargoGUIDList { get; set; }

    [BinaryContent(Name = "Owner", NodeType = BinaryContentTypes.Node)]
    public DestroySpawnInfoListOwner Owner { get; set; }

    [BinaryContent(Name = "VisualOwner", NodeType = BinaryContentTypes.Node)]
    public DestroySpawnInfoListVisualOwner VisualOwner { get; set; }

  }
}