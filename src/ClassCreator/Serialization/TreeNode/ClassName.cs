// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace ClassCreator.Serialization.Tree {

  using System;
  using System.Collections;
  using System.Collections.Generic;
  using System.Linq;
  using System.Runtime.Serialization;
  using Newtonsoft.Json;

  [Serializable]
  [JsonObject(MemberSerialization = MemberSerialization.Fields)]
  public sealed class ClassName : IEquatable<ClassName>, IEnumerable<string> {

    #region Public Properties

    [JsonIgnore]
    public int Count => items.Count;

    #endregion Public Properties

    #region Public Indexers
    [JsonIgnore]
    public string this[int index] { get => ((IList<string>)items)[index]; }

    #endregion Public Indexers

    #region Public Constructors

    public ClassName(IEnumerable<string> collection, params string[] singleItems) {
      items = new List<string>(collection ?? Enumerable.Empty<string>());
      items.AddRange(singleItems ?? Enumerable.Empty<string>());
    }

    #endregion Public Constructors

    #region Public Methods

    public bool Equals(ClassName other) => ArrayEquals(this, other);

    public bool StartsWith(ClassName className) {
      if (Count < className.Count) {
        return false;
      }
      return items.Take(className.Count).SequenceEqual(className);
    }

    public override string ToString() => string.Join('.', this);

    public override bool Equals(object obj) => Equals(obj as ClassName);

    public override int GetHashCode() {
      if (hashCode == default) {
        hashCode = HashCode.Combine(
          items.Count,
          items[^1].GetHashCode(),
          items.Count > 2 ? items[^2].GetHashCode() : 0,
          items.Count > 3 ? items[^3].GetHashCode() : 0,
          items.Count > 4 ? items[^4].GetHashCode() : 0,
          items.Count > 5 ? items[^5].GetHashCode() : 0,
          items.Count > 6 ? items[^6].GetHashCode() : 0,
          items.Count > 7 ? items[^7].GetHashCode() : 0);
      }
      return hashCode;
    }

    public IEnumerator<string> GetEnumerator() => ((IEnumerable<string>)items).GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)items).GetEnumerator();

    #endregion Public Methods

    #region Private Methods

    private bool ArrayEquals(ClassName a, ClassName b) {
      for (int i = a.Count - 1; i >= 0; i--) {
        if (!(a?[i].Equals(b?[i]) ?? false)) {
          return false;
        }
      }
      return true;
    }

    #endregion Private Methods

    #region Private Fields
    [JsonProperty]
    private List<string> items;
    [JsonIgnore]
    private int hashCode;

    #endregion Private Fields

    /*Count == other.Count && this.SequenceEqual(other);*/
  }
}