namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class DecreeStatesList {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<DecreeStatesListList> DecreeStatesListList { get; set; }

  }
}