namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class DiplomacyStates {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<DiplomacyStatesList> DiplomacyStatesList { get; set; }

  }
}