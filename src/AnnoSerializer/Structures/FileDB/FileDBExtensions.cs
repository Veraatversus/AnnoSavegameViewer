// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.FileDB {
  using System;

  public static class FileDBExtensions {

    #region Public Methods

    public static FileDB ToFileDB(this ReadOnlyMemory<byte> memory) => new FileDB(memory);

    #endregion Public Methods
  }
}