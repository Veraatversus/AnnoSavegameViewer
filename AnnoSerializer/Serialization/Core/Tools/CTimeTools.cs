namespace AnnoSerializer.Serialization.Core {
  using System;

  /// <summary> Represents utilities for working with the time_t format of the C library. </summary>
  public static class CTimeTools {

    #region Public Methods

    /// <summary>
    /// Gets the <see cref="DateTime"/> instance representing the given time_t <paramref name="seconds"/>.
    /// </summary>
    /// <param name="seconds"> The number of seconds as counted by the time_t instance. </param>
    /// <returns> The <see cref="DateTime"/> instance. </returns>
    public static DateTime GetDateTime(ulong seconds) => _base.AddSeconds(seconds);

    /// <summary> Calculates the seconds since 1970-01-01 for the given <paramref name="value"/>. </summary>
    /// <param name="value"> The <see cref="DateTime"/> to calculate the seconds for. </param>
    /// <returns> The seconds since 1970-01-01. </returns>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value lies in front of the base date.
    /// </exception>
    public static double GetSeconds(DateTime value) {
      return value < _base
        ? throw new ArgumentOutOfRangeException($"Date {value} cannot be represented by time_t.")
        : (value - _base).TotalSeconds;
    }

    #endregion Public Methods

    #region Private Fields

    private static readonly DateTime _base = new DateTime(1970, 1, 1);

    #endregion Private Fields
  }
}