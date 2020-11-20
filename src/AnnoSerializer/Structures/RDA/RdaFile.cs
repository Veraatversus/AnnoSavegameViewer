// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.RDA {
  using AnnoSerializer.Serialization.Memory;
  using System;

  public class RdaFile {

    #region Public Properties

    public ReadOnlyMemory<byte> FileData { get; set; }
    public FileHeader FileHeader { get; set; }

    #endregion Public Properties

    #region Public Constructors

    public RdaFile(ref MemoryReader reader, BlockHeader header) {
      if ((header.Flags & BlockFlags.Compressed) != 0) {
        var uncompressedHeader = new MemoryReader(reader.Slice(reader.Position, (int)header.CompressedSize).Memory.ZlibDecompress());
        FileHeader = new FileHeader(ref uncompressedHeader);
        FileData = reader.Memory.Slice((int)FileHeader.DataOffset, (int)FileHeader.CompressedSize).ZlibDecompress();
        reader.Position += Constant.FileHeaderSize;
      }
      else {
        FileHeader = new FileHeader(ref reader);
        FileData = reader.Memory.Slice((int)FileHeader.DataOffset, (int)FileHeader.CompressedSize);
      }
    }

    #endregion Public Constructors
  }
}