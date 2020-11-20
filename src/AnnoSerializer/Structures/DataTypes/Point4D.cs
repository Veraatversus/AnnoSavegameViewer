// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.DataTypes {

  using System;
  using System.Diagnostics;
  using AnnoSerializer.Serialization.Core;

  /// <summary> Represents a Point in 3D with <see cref="float"/> precession. </summary>
  [DebuggerDisplay("X = {X}, Y = {Y}, Z = {Z}, W = {W}")]
  public struct Point4D<T> : IEquatable<Point4D<T>> {

    #region Public Properties

    [BinaryContent(Order = 0)]
    public T X { get; set; }

    [BinaryContent(Order = 1)]
    public T Y { get; set; }

    [BinaryContent(Order = 2)]
    public T Z { get; set; }

    [BinaryContent(Order = 3)]
    public T W { get; set; }

    #endregion Public Properties

    #region Public Methods

    public static bool operator ==(Point4D<T> left, Point4D<T> right) => left.Equals(right);

    public static bool operator !=(Point4D<T> left, Point4D<T> right) => !(left == right);

    public override bool Equals(object obj) => obj is Point4D<T> o && Equals(o);

    public bool Equals(Point4D<T> other) => X.Equals(other.X) && Y.Equals(other.Y) && Z.Equals(other.Z) && W.Equals(other.W);

    public override int GetHashCode() => HashCode.Combine(X, Y, Z, W);

    public override string ToString() => $"X={X}, Y={Y}, Z={Z}, W={W}";

    #endregion Public Methods
  }
}