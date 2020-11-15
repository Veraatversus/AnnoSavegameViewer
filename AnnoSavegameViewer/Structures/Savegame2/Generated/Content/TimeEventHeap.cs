namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class TimeEventHeap {

    [BinaryContent(Name = "lastElement", NodeType = BinaryContentTypes.Attribute)]
    public object LastElement { get; set; }

    [BinaryContent(Name = "data", NodeType = BinaryContentTypes.Node)]
    public List<TimeEventHeapData> Data { get; set; }

  }
}