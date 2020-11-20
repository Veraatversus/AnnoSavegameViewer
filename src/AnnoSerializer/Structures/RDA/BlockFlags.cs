// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.RDA {
  using System;

  [Flags]
  public enum BlockFlags {
    None = 0,
    Compressed = 1,
    Encrypted = 2,
    MemoryResistent = 4,
    Deleted = 8
  }
}