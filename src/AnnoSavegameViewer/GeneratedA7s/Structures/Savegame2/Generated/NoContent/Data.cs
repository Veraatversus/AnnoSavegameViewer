namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class Data {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<DataList> DataList { get; set; }

  }
}