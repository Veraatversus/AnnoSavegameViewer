using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class CargoItemsList {

    [BinaryContent(Name = "ID", NodeType = BinaryContentTypes.Attribute)]
    public object ID { get; set; }

    [BinaryContent(Name = "GUID", NodeType = BinaryContentTypes.Attribute)]
    public object GUID { get; set; }

  }
}