using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class WorldManager {

    [BinaryContent(Name = "StreetMap", NodeType = BinaryContentTypes.Node)]
    public StreetMap StreetMap { get; set; }

    [BinaryContent(Name = "RemovedProps", NodeType = BinaryContentTypes.Node)]
    public RemovedProps RemovedProps { get; set; }

    [BinaryContent(Name = "ObjectSpawnerMap", NodeType = BinaryContentTypes.Node)]
    public ObjectSpawnerMap ObjectSpawnerMap { get; set; }

  }
}