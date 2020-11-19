namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class FirstEncounterMusic {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<FirstEncounterMusicList> FirstEncounterMusicList { get; set; }

  }
}