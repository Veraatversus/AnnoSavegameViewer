using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace AnnoSavegameViewer.Structures.Savegame {
  [DebuggerDisplay("{CurrentLang}")]
  public class Description : IEquatable<Description> {
    public virtual int GUID { get; set; }
    public virtual string CurrentLang { get; set; }
    public override string ToString() {
      return CurrentLang;
    }
    public Description() {

    }
    public Description(string text) {
      CurrentLang = text;
      GUID = text.GetHashCode(StringComparison.Ordinal);
    }
    public bool Equals([AllowNull] Description other) {
      return other?.GUID == this.GUID;
    }
  }
}
