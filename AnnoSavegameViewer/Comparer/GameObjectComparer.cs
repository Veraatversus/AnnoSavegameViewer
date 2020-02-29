using AnnoSavegameViewer.Structures.Savegame.Generated;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace AnnoSavegameViewer.Comparer {

  internal class GameObjectComparer : IEqualityComparer<GameObjectObjectsList> {

    #region Public Methods

    public bool Equals([AllowNull] GameObjectObjectsList x, [AllowNull] GameObjectObjectsList y) {
      return x?.Guid?.GUID == y?.Guid?.GUID;
    }

    public int GetHashCode([DisallowNull] GameObjectObjectsList obj) {
      return 0;
    }

    #endregion Public Methods
  }
}