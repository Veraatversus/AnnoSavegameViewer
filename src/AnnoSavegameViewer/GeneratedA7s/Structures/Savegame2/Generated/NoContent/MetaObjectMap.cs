namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class MetaObjectMap {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<MetaObjectMapList> MetaObjectMapList { get; set; }

  }
}