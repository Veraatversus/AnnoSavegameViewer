using AnnoSavegameViewer.Structures.Savegame;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace AnnoSavegameViewer.Comparer {

  public class DescriptionComparer : IEqualityComparer<Description> {

    #region Public Properties

    public static DescriptionComparer Default { get; set; } = new DescriptionComparer();

    #endregion Public Properties

    #region Public Methods

    public bool Equals([AllowNull] Description x, [AllowNull] Description y) {
      return x?.GUID == y?.GUID;
    }

    public int GetHashCode([DisallowNull] Description obj) {
      return obj?.GUID.GetHashCode() ?? 0;
    }

    #endregion Public Methods
  }
}