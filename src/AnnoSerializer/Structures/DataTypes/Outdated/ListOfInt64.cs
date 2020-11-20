// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Savegame {
  using AnnoSerializer.Serialization.Core;
  using System.Collections.Generic;

  public class ListOfInt64 {

    #region Public Properties

    [BinaryContent(NodeType = BinaryContentTypes.Both)]
    public List<long> Items { get; set; }

    #endregion Public Properties
  }
}