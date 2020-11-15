namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class GameSessions {

    #region Public Properties

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Attribute)]
    public List<int> None { get; set; }

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<GameSessionsList> GameSessionsList { get; set; }

    #endregion Public Properties
  }
}