// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.DataTypes {

  using System;
  using AnnoSerializer.Serialization.Core;
  using AnnoSerializer.Serialization.Memory;

  public class HexString {

    #region Public Properties

    [BinaryContent(Order = 0)]
    public ReadOnlyMemory<byte> Bytes { get; set; }

    #endregion Public Properties

    #region Public Methods

    public override string ToString() => Bytes.ToHexString();

    #endregion Public Methods
  }
}