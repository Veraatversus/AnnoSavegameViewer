using System;

namespace AnnoSavegameViewer.Structures.RDA {

  [Flags]
  public enum BlockFlags {
    None,
    Compressed,
    Encrypted,
    MemoryResistent,
    Deleted
  }
}