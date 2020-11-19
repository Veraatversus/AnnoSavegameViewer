namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class ShareInfos {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<ShareInfosList> ShareInfosList { get; set; }

  }
}