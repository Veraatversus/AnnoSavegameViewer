namespace AnnoSerializer.Structures.Savegame {
  using AnnoSerializer.Serialization.Core;
  using AnnoSerializer.Structures.DataTypes;
  using System.Collections.Generic;
  using System.Linq;

  public class DescriptionIntList {

    #region Public Properties

    [BinaryContent(NodeType = BinaryContentTypes.Both)]
    public List<DescriptionInt> GUIDs { get; set; }

    #endregion Public Properties

    #region Public Methods

    public override string ToString() => string.Join(',', GUIDs.Select(g => g.CurrentLang));

    #endregion Public Methods
  }
}