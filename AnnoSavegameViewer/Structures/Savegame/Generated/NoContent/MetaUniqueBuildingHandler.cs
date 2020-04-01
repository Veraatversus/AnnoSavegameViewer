using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class MetaUniqueBuildingHandler {

    [BinaryContent(Name = "AreaUniques", NodeType = BinaryContentTypes.Node)]
    public AreaUniques AreaUniques { get; set; }

    [BinaryContent(Name = "SessionUniques", NodeType = BinaryContentTypes.Node)]
    public SessionUniques SessionUniques { get; set; }

    [BinaryContent(Name = "GameUniques", NodeType = BinaryContentTypes.Node)]
    public GameUniques GameUniques { get; set; }

  }
}