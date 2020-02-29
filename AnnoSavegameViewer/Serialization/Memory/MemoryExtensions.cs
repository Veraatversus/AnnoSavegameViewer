using ICSharpCode.SharpZipLib.Zip.Compression.Streams;
using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace AnnoSavegameViewer.Serialization.Memory {

  public static class MemoryExtensions {

    #region Public Methods

    public static MemoryReader ToReader(this ReadOnlyMemory<byte> span) {
      return new MemoryReader(span);
    }

    public static MemoryReader ToReader(this ReadOnlyMemory<byte> span, out MemoryReader reader) {
      reader = new MemoryReader(span);
      return reader;
    }

    public static string ToHexString(this ReadOnlySpan<byte> Bytes) {
      var Result = new StringBuilder(Bytes.Length * 2);
      const string HexAlphabet = "0123456789ABCDEF";

      foreach (var B in Bytes) {
        Result.Append(HexAlphabet[B >> 4]);
        Result.Append(HexAlphabet[B & 0xF]);
      }

      return Result.ToString();
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

    #endregion Public Methods
  }
}