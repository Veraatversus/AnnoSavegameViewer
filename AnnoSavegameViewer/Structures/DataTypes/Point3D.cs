// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSavegameViewer.Structures.DataTypes {

  using System;
  using System.Diagnostics;
  using AnnoSavegameViewer.Serialization.Core;

  /// <summary> Represents a Point in 3D with <see cref="float"/> precession. </summary>
  [DebuggerDisplay("X = {X}, Y = {Y}, Z = {Z}")]
  public struct Point3D<T> : System.IEquatable<Point3D<T>> {

    #region Public Properties

    [BinaryContent(Order = 0)]
    public T X { get; set; }

    [BinaryContent(Order = 1)]
    public T Y { get; set; }

    [BinaryContent(Order = 2)]
    public T Z { get; set; }

    #endregion Public Properties

    #region Public Methods

    public static bool operator ==(Point3D<T> left, Point3D<T> right) => left.Equals(right);

    public static bool operator !=(Point3D<T> left, Point3D<T> right) => !(left == right);

    public override bool Equals(object obj) => obj is Point3D<T> o && Equals(o);

    public bool Equals(Point3D<T> other) => X.Equals(other.X) && Y.Equals(other.Y) && Z.Equals(other.Z);

    public override int GetHashCode() => HashCode.Combine(X, Y, Z);

    public override string ToString() => $"X={X}, Y={Y}, Z={Z}";

    #endregion Public Methods
  }
}