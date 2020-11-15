using System;

namespace AnnoSavegameViewer.Serialization.Tree {

  [Flags]
  public enum ListTypes {
    None,
    Keys,
    Values,
    Dictionary = Keys | Values
  }
}