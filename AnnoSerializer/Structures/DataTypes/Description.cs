namespace AnnoSerializer.Structures.DataTypes {
  using System;
  using System.Diagnostics;
  using System.Diagnostics.CodeAnalysis;

  [DebuggerDisplay("{CurrentLang}")]
  public class Description : IEquatable<Description> {
    public virtual int GUID { get; set; }
    public virtual string CurrentLang { get; set; }

    public override string ToString() => string.IsNullOrEmpty(CurrentLang) ? GUID.ToString() : CurrentLang;

    public Description() {
    }

    public Description(string text) {
      CurrentLang = text;
      GUID = text.GetHashCode(StringComparison.Ordinal);
    }

    public bool Equals([AllowNull] Description other) => other?.GUID == this.GUID;

    public override bool Equals(object obj) => Equals(obj as Description);
  }
}