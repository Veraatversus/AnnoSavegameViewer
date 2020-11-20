// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Serialization.Core {
  using System;

  [Flags]
  public enum BinaryContentTypes {
    None = 0,
    Node = 1,
    Attribute = 2,
    Both = Node | Attribute
  }
}