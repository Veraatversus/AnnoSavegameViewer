// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Comparer {
  using AnnoSerializer.Structures.DataTypes;
  using System.Collections.Generic;
  using System.Diagnostics.CodeAnalysis;

  public class DescriptionComparer : IEqualityComparer<Description> {

    #region Public Properties

    public static DescriptionComparer Default { get; set; } = new DescriptionComparer();

    #endregion Public Properties

    #region Public Methods

    public bool Equals([AllowNull] Description x, [AllowNull] Description y) => x?.GUID == y?.GUID;

    public int GetHashCode([DisallowNull] Description obj) => obj?.GUID.GetHashCode() ?? 0;

    #endregion Public Methods
  }
}