using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class SequenceData {

    [BinaryContent(Name = "CurrentSequenceID", NodeType = BinaryContentTypes.Attribute)]
    public object CurrentSequenceID { get; set; }

    [BinaryContent(Name = "CurrentSequenceStartTime", NodeType = BinaryContentTypes.Attribute)]
    public object CurrentSequenceStartTime { get; set; }

    [BinaryContent(Name = "IdleSequenceID", NodeType = BinaryContentTypes.Attribute)]
    public object IdleSequenceID { get; set; }

    [BinaryContent(Name = "Dirty", NodeType = BinaryContentTypes.Attribute)]
    public object Dirty { get; set; }

    [BinaryContent(Name = "CurrentSequenceSpeed", NodeType = BinaryContentTypes.Attribute)]
    public object CurrentSequenceSpeed { get; set; }

  }
}