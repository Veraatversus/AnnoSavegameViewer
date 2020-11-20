// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.RDA {
  using AnnoSerializer.Serialization.Memory;

  public class MemoryResisdentInfo {

    #region Public Properties

    public ulong CompressedSize { get; set; }
    public ulong UncompressedSize { get; set; }

    #endregion Public Properties

    #region Public Constructors

    public MemoryResisdentInfo(ref MemoryReader reader) {
      CompressedSize = reader.ReadUInt64();
      UncompressedSize = reader.ReadUInt64();
    }

    #endregion Public Constructors
  }
}