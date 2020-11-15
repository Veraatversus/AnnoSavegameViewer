// Copyright © 2020 Vera@Versus. All rights reserved.
// Licensed under the MIT License.

namespace AnnoSavegameViewer.Structures.DataTypes {

  using System;
  using System.Collections;
  using System.Collections.Generic;
  using System.Diagnostics.CodeAnalysis;
  using System.Linq;
  using AnnoSavegameViewer.Serialization.Core;

  public abstract class KeyValueDictionary<TKey, TValue> : IDictionary<TKey, TValue> {

    #region Public Properties

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Attribute)]
    public abstract List<TKey> Keys { get; set; }

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public abstract List<TValue> Values { get; set; }

    public int Count => dictionary.Value.Count;

    public bool IsReadOnly => ((ICollection<KeyValuePair<TKey, TValue>>)dictionary.Value).IsReadOnly;

    ICollection<TKey> IDictionary<TKey, TValue>.Keys => ((IDictionary<TKey, TValue>)dictionary.Value).Keys;

    ICollection<TValue> IDictionary<TKey, TValue>.Values => ((IDictionary<TKey, TValue>)dictionary.Value).Values;

    #endregion Public Properties

    #region Public Indexers

    public TValue this[TKey key] { get => dictionary.Value[key]; set => ((IDictionary<TKey, TValue>)dictionary)[key] = value; }

    #endregion Public Indexers

    #region Public Methods

    public void Add(TKey key, TValue value) => dictionary.Value.Add(key, value);

    public bool ContainsKey(TKey key) => dictionary.Value.ContainsKey(key);

    public bool Remove(TKey key) => dictionary.Value.Remove(key);

    public bool TryGetValue(TKey key, [MaybeNullWhen(false)] out TValue value) => dictionary.Value.TryGetValue(key, out value);

    public void Add(KeyValuePair<TKey, TValue> item) => ((ICollection<KeyValuePair<TKey, TValue>>)dictionary.Value).Add(item);

    public void Clear() => dictionary.Value.Clear();

    public bool Contains(KeyValuePair<TKey, TValue> item) => ((ICollection<KeyValuePair<TKey, TValue>>)dictionary.Value).Contains(item);

    public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex) => ((ICollection<KeyValuePair<TKey, TValue>>)dictionary.Value).CopyTo(array, arrayIndex);

    public bool Remove(KeyValuePair<TKey, TValue> item) => ((ICollection<KeyValuePair<TKey, TValue>>)dictionary.Value).Remove(item);

    public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator() => ((IEnumerable<KeyValuePair<TKey, TValue>>)dictionary.Value).GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)dictionary.Value).GetEnumerator();

    #endregion Public Methods

    #region Protected Constructors

    protected KeyValueDictionary() {
      Keys = new List<TKey>();
      Values = new List<TValue>();
      dictionary = new Lazy<Dictionary<TKey, TValue>>(() => Keys.Zip(Values).ToDictionary(x => x.First, x => x.Second));
    }

    #endregion Protected Constructors

    #region Private Fields

    private readonly Lazy<Dictionary<TKey, TValue>> dictionary;

    #endregion Private Fields
  }
}