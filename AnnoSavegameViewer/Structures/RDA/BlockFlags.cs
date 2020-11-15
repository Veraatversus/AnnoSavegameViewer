namespace AnnoSavegameViewer.Structures.RDA {
  using System;

  [Flags]
  public enum BlockFlags {
    None,
    Compressed,
    Encrypted,
    MemoryResistent,
    Deleted
  }
}