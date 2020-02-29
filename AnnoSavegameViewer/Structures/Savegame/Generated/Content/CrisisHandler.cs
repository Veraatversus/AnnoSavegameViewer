using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class CrisisHandler {

    #region Public Properties

    [BinaryContent(Name = "LastTick", NodeType = BinaryContentTypes.Attribute)]
    public object LastTick { get; set; }

    [BinaryContent(Name = "Crises", NodeType = BinaryContentTypes.Node)]
    public Crises Crises { get; set; }

    #endregion Public Properties
  }
}