namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class AreaTriggered {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<AreaTriggeredList> AreaTriggeredList { get; set; }

  }
}