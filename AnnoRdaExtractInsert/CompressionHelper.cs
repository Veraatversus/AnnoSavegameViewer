namespace AnnoRdaExtractInsert {
  using Ionic.Zlib;
  using System;
  using System.IO;

  public static class CompressionHelper {

    #region Public Methods

    public static void DecompressFromFile(string path, int position, int leangh) {
      Memory<byte> reader = System.IO.File.ReadAllBytes(path);
      var mem = reader.Slice(position, leangh);
      using var inputStream = new MemoryStream();
      inputStream.Write(mem.Span);
      inputStream.Position = 0;

      using var outputStream = new MemoryStream();
      using var decompressionStream = new ZlibStream(inputStream, Ionic.Zlib.CompressionMode.Decompress);
      decompressionStream.CopyTo(outputStream);
      outputStream.Position = 0;

      File.WriteAllBytes("bytes", outputStream.ToArray());
    }

    public static void InsertBlockCompressed(string path, int position, int leangh) {
      Memory<byte> file = File.ReadAllBytes("bytes");
      using var outputStream = new MemoryStream();
      using var outputStream2 = new MemoryStream();
      outputStream.Write(file.Span);
      outputStream.Position = 0;
      using var compressionStream = new ZlibStream(outputStream, Ionic.Zlib.CompressionMode.Compress, Ionic.Zlib.CompressionLevel.Level2);
      compressionStream.CopyTo(outputStream2);
      outputStream2.Position = 0;
      var data = outputStream2.ToArray();

      Memory<byte> k = System.IO.File.ReadAllBytes(path);
      var slice = k.Slice(position, leangh);
      data.CopyTo(slice);
      File.WriteAllBytes($"{path}_edit", k.ToArray());
    }

    #endregion Public Methods
  }
}