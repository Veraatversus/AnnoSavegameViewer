using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class GameObjectObjects {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<GameObjectObjectsList> GameObjectsList { get; set; }

  }
}