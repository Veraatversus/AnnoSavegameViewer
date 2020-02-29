using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class HarborsList {

    [BinaryContent(Name = "HaborID", NodeType = BinaryContentTypes.Attribute)]
    public object HaborID { get; set; }

    [BinaryContent(Name = "LoadingPierMidPoint", NodeType = BinaryContentTypes.Attribute)]
    public object LoadingPierMidPoint { get; set; }

    [BinaryContent(Name = "AwayFromCoast", NodeType = BinaryContentTypes.Attribute)]
    public object AwayFromCoast { get; set; }

    [BinaryContent(Name = "OwnerID", NodeType = BinaryContentTypes.Node)]
    public HarborsListOwnerID OwnerID { get; set; }

    [BinaryContent(Name = "HaborType", NodeType = BinaryContentTypes.Node)]
    public HaborType HaborType { get; set; }

    [BinaryContent(Name = "LoadingPiers", NodeType = BinaryContentTypes.Node)]
    public LoadingPiers LoadingPiers { get; set; }

    [BinaryContent(Name = "WaitingQueueMap", NodeType = BinaryContentTypes.Node)]
    public WaitingQueueMap WaitingQueueMap { get; set; }

  }
}