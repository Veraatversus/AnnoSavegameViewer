using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class CustomCompanyColorList {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public CustomCompanyColorListValue Value { get; set; }

  }
}