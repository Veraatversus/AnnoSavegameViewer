// Copyright © 2020 Vera@Versus. All rights reserved.
// Licensed under the MIT License.

namespace AnnoSavegameViewer.Comparer {
  using System.Collections.Generic;
  using System.Diagnostics.CodeAnalysis;
  using AnnoSerializer.Structures.Generated.a7s;

  internal class GameObjectComparer : IEqualityComparer<GameObjectObjectsValue> {

    #region Public Methods

    public bool Equals([AllowNull] GameObjectObjectsValue x, [AllowNull] GameObjectObjectsValue y) => x?.Guid?.GUID == y?.Guid?.GUID;

    public int GetHashCode([DisallowNull] GameObjectObjectsValue obj) => 0;

    #endregion Public Methods
  }
}