namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class Objects {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<ObjectsList> ObjectsList { get; set; }

  }
}