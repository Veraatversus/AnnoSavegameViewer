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