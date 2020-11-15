namespace AnnoSerializer.Serialization.Core {
  using System;

  /// <summary> Represents the set of formats of binary time encodings. </summary>
  public enum TimeSpanPattern {

    /// <summary> The <see cref="TimeSpan"/> is stored as milliseconds. </summary>
    MilliSeconds,

    /// <summary> The <see cref="TimeSpan"/> is stored as Seconds. </summary>
    Seconds,

    /// <summary> The <see cref="TimeSpan"/> is stored as Minutes. </summary>
    Minutes,

    /// <summary> The <see cref="TimeSpan"/> is stored as Hours. </summary>
    Hours,

    /// <summary> The <see cref="TimeSpan"/> is stored as Days. </summary>
    Days,

    /// <summary>
    /// The <see cref="TimeSpan"/> is stored as the ticks of a .NET <see cref="TimeSpan"/> instance.
    /// </summary>
    Ticks
  }
}