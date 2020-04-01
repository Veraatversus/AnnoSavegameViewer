using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ObjectGroupCollection {

    [BinaryContent(Name = "ObjectGroups", NodeType = BinaryContentTypes.Node)]
    public ObjectGroupCollectionObjectGroups ObjectGroups { get; set; }

  }
}