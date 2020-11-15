namespace AnnoSerializer.Structures.DataTypes {

  using System;
  using System.Globalization;
  using System.Text.RegularExpressions;
  using AnnoSerializer.Converter;
  using AnnoSerializer.Serialization.Core;

  /// <summary> Represents a Point in 2D with <see cref="int"/> precession. </summary>
  public struct Point2D<T> : IEquatable<Point2D<T>> {

    #region Public Properties

    [BinaryContent(Order = 0)]
    public T X { get; set; }

    [BinaryContent(Order = 1)]
    public T Y { get; set; }

    #endregion Public Properties

    #region Public Methods

    public static Point2D<T> Parse(string value) {
      if (ParseRegex.Match(value) is Match match && match.Success) {
        var point = new Point2D<T> {
          X = (T)StringParseConverter.TryParse(match.Groups[1].Value, typeof(T), CultureInfo.CurrentCulture),
          Y = (T)StringParseConverter.TryParse(match.Groups[2].Value, typeof(T), CultureInfo.CurrentCulture)
        };
        return point;
      }
      throw new ArgumentException(value);
    }

    public static bool operator ==(Point2D<T> left, Point2D<T> right) => left.Equals(right);

    public static bool operator !=(Point2D<T> left, Point2D<T> right) => !(left == right);

    public override string ToString() => $"X={X}, Y={Y}";

    public override int GetHashCode() => HashCode.Combine(X, Y);

    public bool Equals(Point2D<T> other) => X.Equals(other.X) && Y.Equals(other.Y);

    public override bool Equals(object obj) => obj is Point2D<T> o && Equals(o);

    #endregion Public Methods

    #region Private Fields

    private static readonly Regex ParseRegex = new Regex("X=(.*), Y=(.*)");

    #endregion Private Fields
  }
}