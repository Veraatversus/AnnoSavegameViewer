using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class FirstEncounterMusicList {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public FirstEncounterMusicListValue Value { get; set; }

  }
}