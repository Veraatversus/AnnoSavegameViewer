using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Object {

    [BinaryContent(Name = "ObjectID", NodeType = BinaryContentTypes.Attribute)]
    public object ObjectID { get; set; }

  }
}