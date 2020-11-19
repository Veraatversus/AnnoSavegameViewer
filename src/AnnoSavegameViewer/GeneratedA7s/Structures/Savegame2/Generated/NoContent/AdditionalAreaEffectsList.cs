namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class AdditionalAreaEffectsList {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<AdditionalAreaEffectsListList> AdditionalAreaEffectsListList { get; set; }

  }
}