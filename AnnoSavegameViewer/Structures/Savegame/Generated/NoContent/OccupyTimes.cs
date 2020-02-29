using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class OccupyTimes {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<OccupyTimesList> OccupyTimesList { get; set; }

  }
}