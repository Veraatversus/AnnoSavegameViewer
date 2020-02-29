using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame {

  public class AnnoUpgradeGUIDS {

    #region Public Properties

    [BinaryContent(NodeType = BinaryContentTypes.Both)]
    public List<DescriptionInt> GUIDs { get; set; }

    #endregion Public Properties
  }
}