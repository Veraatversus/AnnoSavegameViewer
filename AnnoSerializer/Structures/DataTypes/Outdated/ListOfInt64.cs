namespace AnnoSerializer.Structures.Savegame {
  using AnnoSerializer.Serialization.Core;
  using System;
  using System.Collections.Generic;

  public class ListOfInt64 {

    #region Public Properties

    [BinaryContent(NodeType = BinaryContentTypes.Both)]
    public List<long> Items { get; set; }

    #endregion Public Properties
  }
}