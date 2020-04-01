using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class FogOfWar {

    [BinaryContent(Name = "IsInitialized", NodeType = BinaryContentTypes.Attribute)]
    public object IsInitialized { get; set; }

    [BinaryContent(Name = "DiscoverRadius", NodeType = BinaryContentTypes.Attribute)]
    public object DiscoverRadius { get; set; }

    [BinaryContent(Name = "FOWArea", NodeType = BinaryContentTypes.Attribute)]
    public object FOWArea { get; set; }

    [BinaryContent(Name = "FowIsland", NodeType = BinaryContentTypes.Attribute)]
    public object FowIsland { get; set; }

    [BinaryContent(Name = "FOWGrid", NodeType = BinaryContentTypes.Node)]
    public FOWGrid FOWGrid { get; set; }

    [BinaryContent(Name = "Objects", NodeType = BinaryContentTypes.Node)]
    public FogOfWarObjects Objects { get; set; }

    [BinaryContent(Name = "FogsOfWar", NodeType = BinaryContentTypes.Node)]
    public FogsOfWar FogsOfWar { get; set; }

  }
}