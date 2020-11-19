// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.RDA {
  using AnnoSerializer.Serialization.Core;
  using AnnoSerializer.Serialization.Memory;
  using System;
  using System.Text;

  public class RdaHeader {

    #region Public Properties

    public string Magic { get; set; }
    public ReadOnlyMemory<byte> Unknown { get; set; }
    public ulong FirstBlockHeaderOffset { get; set; }

    #endregion Public Properties

    #region Public Constructors

    public RdaHeader(ref MemoryReader reader) {
      Magic = reader.ReadString(Encoding.UTF8, StringPattern.FixCharCount, 18);
      Unknown = reader.Memory[..766];
      reader.Position += 766;
      FirstBlockHeaderOffset = reader.ReadUInt64();
    }

    #endregion Public Constructors
  }
}