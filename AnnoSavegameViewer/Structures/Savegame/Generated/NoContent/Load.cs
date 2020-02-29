using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Load {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<LoadList> LoadList { get; set; }

  }
}