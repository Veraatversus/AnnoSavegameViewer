using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class AttackerDataList {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<AttackerDataListList> AttackerDataListList { get; set; }

  }
}