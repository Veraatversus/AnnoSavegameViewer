using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class FakePingObjectSettingsListObjectsList {

    [BinaryContent(Name = "ObjectID", NodeType = BinaryContentTypes.Attribute)]
    public object ObjectID { get; set; }

    [BinaryContent(Name = "CargoItems", NodeType = BinaryContentTypes.Node)]
    public FakePingObjectSettingsListObjectsListCargoItems CargoItems { get; set; }

  }
}