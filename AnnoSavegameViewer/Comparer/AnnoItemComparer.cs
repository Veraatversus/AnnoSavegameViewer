using AnnoSavegameViewer.Templates;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace AnnoSavegameViewer.Comparer {

  public class AnnoItemComparer : IEqualityComparer<AnnoItem> {

    #region Public Properties

    public static AnnoItemComparer Default { get; set; } = new AnnoItemComparer();

    #endregion Public Properties

    #region Public Methods

    public bool Equals([AllowNull] AnnoItem x, [AllowNull] AnnoItem y) {
      return x?.GUID?.GUID == y?.GUID?.GUID;
    }

    public int GetHashCode([DisallowNull] AnnoItem obj) {
      return obj?.GUID?.GUID.GetHashCode() ?? 0;
    }

    #endregion Public Methods
  }
}