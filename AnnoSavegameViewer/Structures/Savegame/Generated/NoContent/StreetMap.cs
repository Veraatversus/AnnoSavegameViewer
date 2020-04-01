using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class StreetMap {

    [BinaryContent(Name = "StreetID", NodeType = BinaryContentTypes.Node)]
    public StreetID StreetID { get; set; }

    [BinaryContent(Name = "VarMapData", NodeType = BinaryContentTypes.Node)]
    public VarMapData VarMapData { get; set; }

  }
}