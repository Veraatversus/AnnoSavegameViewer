// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Savegame {
  using AnnoSerializer.Serialization.Core;
  using AnnoSerializer.Structures.DataTypes;
  using System.Collections.Generic;
  using System.Linq;

  public class DescriptionShortList {

    #region Public Properties

    [BinaryContent(NodeType = BinaryContentTypes.Both)]
    public List<DescriptionShort> GUIDs { get; set; }

    #endregion Public Properties

    #region Public Methods

    public override string ToString() => string.Join(',', GUIDs.Select(g => g.ToString()));

    #endregion Public Methods
  }
}