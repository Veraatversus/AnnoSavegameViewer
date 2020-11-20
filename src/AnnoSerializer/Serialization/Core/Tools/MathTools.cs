// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Serialization.Core {

  /// <summary> Represents utilities for mathematical operations. </summary>
  public static class MathTools {

    #region Public Methods

    /// <summary>
    /// Calculates the delta required to add to <paramref name="position"/> to reach the given
    /// <paramref name="alignment"/>.
    /// </summary>
    /// <param name="position"> The initial position. </param>
    /// <param name="alignment">
    /// The multiple to align to. If negative, the delta is negative to reach the previous multiple
    /// rather than the next one.
    /// </param>
    /// <returns> The delta to add to the position. </returns>
    public static int GetAlignmentDelta(int position, int alignment) => ((-position % alignment) + alignment) % alignment;

    #endregion Public Methods
  }
}