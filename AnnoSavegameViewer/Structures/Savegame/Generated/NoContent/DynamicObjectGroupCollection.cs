using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class DynamicObjectGroupCollection {

    [BinaryContent(Name = "ObjectGroups", NodeType = BinaryContentTypes.Node)]
    public ObjectGroups ObjectGroups { get; set; }

  }
}