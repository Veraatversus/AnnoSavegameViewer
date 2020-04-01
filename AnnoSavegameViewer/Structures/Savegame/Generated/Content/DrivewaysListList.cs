using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class DrivewaysListList {

    [BinaryContent(Name = "Driveway", NodeType = BinaryContentTypes.Attribute)]
    public object Driveway { get; set; }

    [BinaryContent(Name = "Rotation", NodeType = BinaryContentTypes.Attribute)]
    public object Rotation { get; set; }

  }
}