using System;

namespace AnnoSerializer.Serialization.Tree {

  [Flags]
  public enum ListTypes {
    None,
    Keys,
    Values,
    Dictionary = Keys | Values
  }
}