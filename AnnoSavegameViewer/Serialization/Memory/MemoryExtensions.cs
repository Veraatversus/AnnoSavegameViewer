namespace AnnoSavegameViewer.Serialization.Memory {
  using ICSharpCode.SharpZipLib.Zip.Compression.Streams;
  using System;
  using System.IO;
  using System.Threading.Tasks;

  public static class MemoryExtensions {

    #region Public Methods

    public static MemoryReader ToReader(this ReadOnlyMemory<byte> span) => new MemoryReader(span);

    public static MemoryReader ToReader(this ReadOnlyMemory<byte> span, out MemoryReader reader) {
      reader = new MemoryReader(span);
      return reader;
    }

    public static string ToHexString(this ReadOnlyMemory<byte> Bytes) {
      return string.Create(Bytes.Length * 3, Bytes, (buffer, bytes) => {
        var i = 0;
        foreach (var item in bytes.Span) {
          buffer[i * 3] = HexAlphabet[item >> 4];
          buffer[(i * 3) + 1] = HexAlphabet[item & 0xF];
          buffer[(i * 3) + 2] = ' ';
          i++;
        }
      });
    }

    public async static Task<byte[]> ZlibDecompressAsync(this ReadOnlyMemory<byte> bytesToDecompress) {
      using var inputStream = new MemoryStream();
      await inputStream.WriteAsync(bytesToDecompress);
      using var outputStream = new MemoryStream();
      inputStream.Position = 0;
      using var decompressionStream = new InflaterInputStream(inputStream);
      await decompressionStream.CopyToAsync(outputStream);
      return outputStream.ToArray();
    }

    public static byte[] ZlibDecompress(this ReadOnlyMemory<byte> bytesToDecompress) {
      using var inputStream = new MemoryStream();
      inputStream.Write(bytesToDecompress.Span);
      using var outputStream = new MemoryStream();
      inputStream.Position = 0;
      using var decompressionStream = new InflaterInputStream(inputStream);
      decompressionStream.CopyTo(outputStream);
      return outputStream.ToArray();
    }

    #endregion Public Methods

    #region Private Fields

    private const string HexAlphabet = "0123456789ABCDEF";

    #endregion Private Fields
  }
}