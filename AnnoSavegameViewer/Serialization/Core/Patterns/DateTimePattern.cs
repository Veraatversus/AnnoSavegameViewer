namespace AnnoSavegameViewer.Serialization.Core {
  using System;

  /// <summary> Represents the set of formats of binary date and time encodings. </summary>
  public enum DateTimePattern {

    /// <summary>
    /// The <see cref="DateTime"/> has the 32-bit time_t format of the C library. This is a <see
    /// cref="uint"/> which can store the seconds from 1970-01-01 until approx. 2106-02-07.
    /// </summary>
    CTime,

    /// <summary>
    /// The <see cref="DateTime"/> has the 64-bit time_t format of the C library. This is an <see
    /// cref="long"/> which can store the seconds from 1970-01-01 until approx. 292277026596-12-04.
    /// </summary>
    CTime64,

    /// <summary>
    /// The <see cref="DateTime"/> is stored as the ticks of a .NET <see cref="DateTime"/> instance.
    /// </summary>
    NetTicks
  }
}