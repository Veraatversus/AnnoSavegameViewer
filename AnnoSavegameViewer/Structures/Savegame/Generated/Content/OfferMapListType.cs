using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class OfferMapListType {

    [BinaryContent(Name = "Type", NodeType = BinaryContentTypes.Attribute)]
    public object Type { get; set; }

  }
}