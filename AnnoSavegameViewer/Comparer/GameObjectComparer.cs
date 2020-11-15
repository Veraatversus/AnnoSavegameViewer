namespace AnnoSavegameViewer.Comparer {
  using AnnoSavegameViewer.Structures.Savegame.Generated;
  using System.Collections.Generic;
  using System.Diagnostics.CodeAnalysis;

  internal class GameObjectComparer : IEqualityComparer<GameObjectObjectsList> {

    #region Public Methods

    public bool Equals([AllowNull] GameObjectObjectsList x, [AllowNull] GameObjectObjectsList y) => x?.Guid?.GUID == y?.Guid?.GUID;

    public int GetHashCode([DisallowNull] GameObjectObjectsList obj) => 0;

    #endregion Public Methods
  }
}