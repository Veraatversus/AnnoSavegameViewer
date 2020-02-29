using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class WorkerInfoList {

    [BinaryContent(Name = "state", NodeType = BinaryContentTypes.Attribute)]
    public object State { get; set; }

    [BinaryContent(Name = "nextTimestamp", NodeType = BinaryContentTypes.Attribute)]
    public object NextTimestamp { get; set; }

    [BinaryContent(Name = "positionalData", NodeType = BinaryContentTypes.Attribute)]
    public object PositionalData { get; set; }

    [BinaryContent(Name = "forceReturn", NodeType = BinaryContentTypes.Attribute)]
    public object ForceReturn { get; set; }

  }
}