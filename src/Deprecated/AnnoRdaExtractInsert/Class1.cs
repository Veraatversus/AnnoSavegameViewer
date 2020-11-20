using System;
using System.IO;
using System.IO.Compression;

namespace AnnoRDA.IO.Compression {
  public class ZlibStream : Stream {
    private readonly DeflateStream deflateStream;
    CompressionMode compressionMode;
    private readonly bool leaveOpen;

    private ulong checksum = 1;

    private bool disposed = false;

    public ZlibStream(Stream stream, CompressionMode compressionMode, bool leaveOpen = false) {
      if (stream == null) {
        throw new ArgumentNullException("stream");
      }

      switch (compressionMode) {
        case CompressionMode.Compress:
          this.deflateStream = CreateDeflateStreamForWriting(stream, true);
          break;

        case CompressionMode.Decompress:
          this.deflateStream = CreateDeflateStreamForReading(stream, true);
          break;
      }
      this.compressionMode = compressionMode;
      this.leaveOpen = leaveOpen;
    }

    private static DeflateStream CreateDeflateStreamForWriting(Stream stream, bool leaveOpen) {
      if (!stream.CanWrite) {
        throw new ArgumentException("The stream must support writing", "stream");
      }

      stream.WriteByte(0x78); // Deflate with maximum window size
      stream.WriteByte(0x01); // fastest compression, no preset dictionary, 1 for header checksum

      return new DeflateStream(stream, CompressionMode.Compress, leaveOpen);
    }
    private static DeflateStream CreateDeflateStreamForReading(Stream stream, bool leaveOpen) {
      if (!stream.CanRead) {
        throw new ArgumentException("The stream must support reading", "stream");
      }

      int compressionMethodAndFlags = stream.ReadByte();
      int flags = stream.ReadByte();

      if (compressionMethodAndFlags == -1 || flags == -1) {
        throw new EndOfStreamException();
      }

      if (((compressionMethodAndFlags << 8) + flags) % 31 != 0) {
        throw new System.FormatException("stream is not a valid zlib stream");
      }

      int compressionMethod = compressionMethodAndFlags & 0xF;
      if (compressionMethod != 8) {
        throw new NotSupportedException("Compression method " + compressionMethod + " is not supported");
      }

      if ((flags & 0x10) != 0) {
        // skip DICTID
        byte[] buffer = new byte[4];
        if (stream.Read(buffer, 0, 4) < 4) {
          throw new EndOfStreamException();
        }
      }

      long offset = stream.Position;
      long length = stream.Length - offset - 4; // - 4 for ADLER-32 checksum

      SubStream subStream = new SubStream(stream, offset, length, leaveOpen);

      try {
        return new DeflateStream(subStream, CompressionMode.Decompress, false);
      }
      catch {
        subStream.Dispose();
        throw;
      }
    }

    public override bool CanRead {
      get {
        return this.deflateStream.CanRead;
      }
    }
    public override bool CanSeek {
      get {
        return this.deflateStream.CanSeek;
      }
    }
    public override bool CanTimeout {
      get {
        return this.deflateStream.CanTimeout;
      }
    }
    public override bool CanWrite {
      get {
        return this.deflateStream.CanWrite;
      }
    }
    public override long Length {
      get {
        return this.deflateStream.Length;
      }
    }
    public override long Position {
      get {
        return this.deflateStream.Position;
      }
      set {
        this.deflateStream.Position = value;
      }
    }
    public override int ReadTimeout {
      get {
        return this.deflateStream.ReadTimeout;
      }
      set {
        this.deflateStream.ReadTimeout = value;
      }
    }
    public override int WriteTimeout {
      get {
        return this.deflateStream.WriteTimeout;
      }
      set {
        this.deflateStream.WriteTimeout = value;
      }
    }

    public override void Flush() {
      this.deflateStream.Flush();
    }
    public override int Read(byte[] buffer, int bufferOffset, int count) {
      return this.deflateStream.Read(buffer, bufferOffset, count);
    }
    public override long Seek(long seekOffset, SeekOrigin origin) {
      return this.deflateStream.Seek(seekOffset, origin);
    }
    public override void SetLength(long value) {
      this.deflateStream.SetLength(value);
    }
    public override void Write(byte[] buffer, int offset, int count) {
      this.deflateStream.Write(buffer, offset, count);
      this.checksum = UpdateChecksum(this.checksum, buffer, offset, count);
    }
    protected override void Dispose(bool disposing) {
      if (this.disposed) {
        return;
      }

      try {
        if (disposing) {
          // Flush and free the deflate stream. Base stream is left open.
          Stream baseStream = this.deflateStream.BaseStream;
          this.deflateStream.Dispose();

          if (this.compressionMode == CompressionMode.Compress) {
            // write the checksum (MSB order)
            byte[] buffer = new byte[4];
            buffer[0] = (byte)((this.checksum >> 24) & 0xFF);
            buffer[1] = (byte)((this.checksum >> 16) & 0xFF);
            buffer[2] = (byte)((this.checksum >> 8) & 0xFF);
            buffer[3] = (byte)((this.checksum >> 0) & 0xFF);
            baseStream.Write(buffer, 0, 4);
          }

          if (!this.leaveOpen) {
            baseStream.Dispose();
          }
        }
      }
      finally {
        this.disposed = true;
        base.Dispose(disposing);
      }
    }


    private static ulong UpdateChecksum(ulong current, byte[] buffer, int offset, int count) {
      // Calculate the new ADLER-32 checksum after working through buffer.
      // This code was copied from RFC 1950 (9. Appendix: Sample code) and adapted to support offset and count.

      const ulong BASE = 65521;

      ulong s1 = current & 0xffff;
      ulong s2 = (current >> 16) & 0xffff;

      int endIndex = Math.Min(buffer.Length, offset + count);
      for (int n = offset; n < endIndex; ++n) {
        s1 = (s1 + buffer[n]) % BASE;
        s2 = (s2 + s1) % BASE;
      }
      return (s2 << 16) + s1;
    }
  }
}