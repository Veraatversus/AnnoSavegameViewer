namespace AnnoSerializer.Structures.DataTypes {
  using AnnoSerializer.Serialization.Core;
  using AnnoSerializer.Serialization.Memory;
  using System;

  public class HexString {

    #region Public Properties

    [BinaryContent(Order = 0)]
    public ReadOnlyMemory<byte> bytes { get; set; }

    #endregion Public Properties

    #region Public Methods

    public override string ToString() => bytes.ToHexString();

    #endregion Public Methods
  }
}