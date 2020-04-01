using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ObjectGroupCollectionObjectGroupsList {

    [BinaryContent(Name = "GameObjects", NodeType = BinaryContentTypes.Node)]
    public GameObjects GameObjects { get; set; }

  }
}