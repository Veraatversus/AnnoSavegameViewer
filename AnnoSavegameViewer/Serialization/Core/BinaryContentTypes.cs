using System;

namespace AnnoSavegameViewer.Serialization.Core {

  [Flags]
  public enum BinaryContentTypes {
    None,
    Node,
    Attribute,
    Both = Node | Attribute
  }
}