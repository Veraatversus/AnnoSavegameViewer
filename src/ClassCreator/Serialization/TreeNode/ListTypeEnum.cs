// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace ClassCreator.Serialization.Tree {

  using System;

  [Flags]
  public enum ListTypes {
    None = 0,
    Keys = 1,
    Values = 2,
    Dictionary = Keys | Values
  }
}