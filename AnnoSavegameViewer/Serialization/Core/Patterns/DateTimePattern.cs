using System;

namespace AnnoSavegameViewer.Serialization.Core {

  /// <summary>
  /// Represents the set of formats of binary date and time encodings.
  /// </summary>
  public enum DateTimePattern {

    /// <summary>
    /// The <see cref="DateTime"/> has the 32-bit time_t format of the C library. This is a <see
    /// cref="UInt32"/> which can store the seconds from 1970-01-01 until approx. 2106-02-07.
    /// </summary>
    CTime,

    /// <summary>
    /// The <see cref="DateTime"/> has the 64-bit time_t format of the C library. This is an <see
    /// cref="Int64"/> which can store the seconds from 1970-01-01 until approx. 292277026596-12-04.
    /// </summary>
    CTime64,

    /// <summary>
    /// The <see cref="DateTime"/> is stored as the ticks of a .NET <see cref="DateTime"/> instance.
    /// </summary>
    NetTicks
  }
}