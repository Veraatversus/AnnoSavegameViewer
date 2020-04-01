using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class EscortDestinationInfoList {

    [BinaryContent(Name = "PrebuiltObjectSettingsIndex", NodeType = BinaryContentTypes.Attribute)]
    public object PrebuiltObjectSettingsIndex { get; set; }

    [BinaryContent(Name = "EscortMoveDirection", NodeType = BinaryContentTypes.Node)]
    public EscortMoveDirection EscortMoveDirection { get; set; }

    [BinaryContent(Name = "EscortTargetGUID", NodeType = BinaryContentTypes.Node)]
    public EscortTargetGUID EscortTargetGUID { get; set; }

  }
}