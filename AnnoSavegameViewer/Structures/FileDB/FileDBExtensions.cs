namespace AnnoSavegameViewer.Structures.FileDB {
  using System;

  public static class FileDBExtensions {

    #region Public Methods

    public static FileDB ToFileDB(this ReadOnlyMemory<byte> memory) => new FileDB(memory);

    #endregion Public Methods
  }
}