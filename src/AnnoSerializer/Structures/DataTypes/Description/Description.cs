// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.DataTypes {

  using System;
  using System.Collections;
  using System.Diagnostics;
  using System.Diagnostics.CodeAnalysis;

  [DebuggerDisplay("{CurrentLang}")]
  public class Description : IEquatable<Description>, IEqualityComparer {

    #region Public Properties

    public virtual int GUID { get; set; }
    public virtual string CurrentLang { get; set; }

    #endregion Public Properties

    #region Public Constructors

    public Description() {
    }

    public Description(string text) {
      CurrentLang = text;
      GUID = text.GetHashCode(StringComparison.Ordinal);
    }

    #endregion Public Constructors

    #region Public Methods

    public override string ToString() => string.IsNullOrEmpty(CurrentLang) ? GUID.ToString() : CurrentLang;

    public bool Equals([AllowNull] Description other) => other?.GUID == this.GUID;

    public override bool Equals(object obj) => Equals(obj as Description);

    public override int GetHashCode() => GUID.GetHashCode();
    public new bool Equals(object x, object y) => (x as Description)?.Equals(y) ?? false;
    public int GetHashCode(object obj) => (obj as Description)?.GetHashCode() ?? 0;

    #endregion Public Methods
  }
}