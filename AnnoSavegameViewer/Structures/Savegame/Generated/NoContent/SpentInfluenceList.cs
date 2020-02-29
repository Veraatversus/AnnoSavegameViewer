using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class SpentInfluenceList {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public SpentInfluenceListValue Value { get; set; }

  }
}