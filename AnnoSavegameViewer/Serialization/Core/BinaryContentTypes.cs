namespace AnnoSavegameViewer.Serialization.Core {
  using System;

  [Flags]
  public enum BinaryContentTypes {
    None,
    Node,
    Attribute,
    Both = Node | Attribute
  }
}