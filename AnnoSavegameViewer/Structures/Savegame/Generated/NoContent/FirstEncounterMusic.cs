using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class FirstEncounterMusic {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<FirstEncounterMusicList> FirstEncounterMusicList { get; set; }

  }
}