// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.DataTypes {

  using System;
  using System.Collections;
  using System.Collections.Generic;
  using System.Linq;
  using AnnoSerializer.Serialization.Core;

  public abstract class KeysList<T> : IList<T>, IList {

    #region Public Properties

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Attribute)]
    public abstract List<T> Keys { get; set; }

    public int Count => Keys?.Count ?? 0;
    public bool IsReadOnly => ((ICollection<T>)ProxyValue).IsReadOnly;

    public bool IsFixedSize => ((IList)ProxyValue).IsFixedSize;

    public bool IsSynchronized => ((ICollection)Keys)?.IsSynchronized ?? false;

    public object SyncRoot => ((ICollection)ProxyValue).SyncRoot;

    #endregion Public Properties

    #region Public Indexers

    public T this[int index] { get => ProxyValue[index]; set => ProxyValue[index] = value; }
    object IList.this[int index] { get => ((IList)ProxyValue)[index]; set => ((IList)ProxyValue)[index] = value; }

    #endregion Public Indexers

    #region Public Methods

    public void Add(T item) => ProxyValue.Add(item);

    public void Clear() => Keys?.Clear();

    public bool Contains(T item) => Keys?.Contains(item) ?? false;

    public IEnumerator<T> GetEnumerator() => ((IEnumerable<T>)Keys)?.GetEnumerator() ?? Enumerable.Empty<T>().GetEnumerator();

    public int IndexOf(T item) => Keys?.IndexOf(item) ?? -1;

    public void Insert(int index, T item) => ProxyValue.Insert(index, item);

    public bool Remove(T item) => Keys?.Remove(item) ?? false;

    public void RemoveAt(int index) => Keys?.RemoveAt(index);

    public int Add(object value) => ((IList)ProxyValue).Add(value);

    public bool Contains(object value) => ((IList)Keys)?.Contains(value) ?? false;

    public int IndexOf(object value) => ((IList)Keys)?.IndexOf(value) ?? -1;

    public void Insert(int index, object value) => ((IList)ProxyValue).Insert(index, value);

    public void Remove(object value) => ((IList)Keys)?.Remove(value);

    public void CopyTo(T[] array, int arrayIndex) => Keys?.CopyTo(array, arrayIndex);

    public void CopyTo(Array array, int index) => ((ICollection)Keys)?.CopyTo(array, index);

    IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)Keys)?.GetEnumerator() ?? Enumerable.Empty<T>().GetEnumerator();

    #endregion Public Methods

    #region Private Properties

    private List<T> ProxyValue {
      get {
        if (Keys is null) {
          Keys = new List<T>();
        }
        return Keys;
      }
    }

    #endregion Private Properties
  }
}