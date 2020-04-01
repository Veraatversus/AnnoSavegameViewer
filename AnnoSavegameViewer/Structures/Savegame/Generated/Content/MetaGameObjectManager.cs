using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class MetaGameObjectManager {

    [BinaryContent(Name = "NextMetaGameObjectID", NodeType = BinaryContentTypes.Attribute)]
    public object NextMetaGameObjectID { get; set; }

    [BinaryContent(Name = "MetaObjectMap", NodeType = BinaryContentTypes.Node)]
    public MetaObjectMap MetaObjectMap { get; set; }

  }
}