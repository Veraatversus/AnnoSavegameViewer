namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class DiplomaticRelations {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<DiplomaticRelationsList> DiplomaticRelationsList { get; set; }

  }
}