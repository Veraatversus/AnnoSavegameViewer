// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Serialization.Memory {
  using CSharpCode.SharpZipLib.Zip.Compression.Streams;
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
      var span = Bytes;
      if (span.Length > 200) {
        span = span.Slice(0, 200);
      }
      //return BitConverter.ToString(span.ToArray()));
      return string.Create(span.Length * 3, span, (buffer, bytes) => {
        var i = 0;
        foreach (var item in bytes.Span) {
          var index = i * 3;
          buffer[index] = HexAlphabet[item >> 4];
          buffer[index + 1] = HexAlphabet[item & 0xF];
          buffer[index + 2] = ' ';
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
      inputStream.Position = 0;
      using var decompressionStream = new InflaterInputStream(inputStream);
      using var outputStream = new MemoryStream();
      decompressionStream.CopyTo(outputStream);
      return outputStream.ToArray();
    }

    #endregion Public Methods

    #region Private Fields

    private const string HexAlphabet = "0123456789ABCDEF";

    #endregion Private Fields
  }
}