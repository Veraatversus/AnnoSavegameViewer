using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class BuildingModule {

    [BinaryContent(Name = "ParentFactoryID", NodeType = BinaryContentTypes.Attribute)]
    public object ParentFactoryID { get; set; }

    [BinaryContent(Name = "CultureSlotIndex", NodeType = BinaryContentTypes.Attribute)]
    public object CultureSlotIndex { get; set; }

  }
}