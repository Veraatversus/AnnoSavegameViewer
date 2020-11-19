// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

/// <summary> Represents a Point in 2D with <see cref="Int32"/> precession. </summary>
namespace AnnoSerializer.Structures.Savegame {
  using AnnoSerializer.Serialization.Core;

  public struct Point2DInt {

    #region Public Properties

    [BinaryContent(Order = 0)]
    public int X { get; set; }

    [BinaryContent(Order = 1)]
    public int Y { get; set; }

    #endregion Public Properties

    #region Public Methods

    public override string ToString() => $"X={X}, Y={Y}";

    #endregion Public Methods
  }
}