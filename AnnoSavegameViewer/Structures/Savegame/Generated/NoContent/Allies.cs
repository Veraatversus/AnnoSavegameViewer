using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Allies {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public AlliesList AlliesList { get; set; }

  }
}