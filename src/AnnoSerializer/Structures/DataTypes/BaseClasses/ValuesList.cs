// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.DataTypes {

  using System;
  using System.Collections;
  using System.Collections.Generic;
  using System.Linq;
  using AnnoSerializer.Serialization.Core;

  public abstract class ValuesList<T> : IList<T>, IList {

    #region Public Properties

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public abstract List<T> Values { get; set; }

    public int Count => Values?.Count ?? 0;

    public bool IsReadOnly => ((ICollection<T>)ProxyValue).IsReadOnly;

    public bool IsFixedSize => ((IList)ProxyValue).IsFixedSize;

    public bool IsSynchronized => ((ICollection)Values)?.IsSynchronized ?? false;

    public object SyncRoot => ((ICollection)ProxyValue).SyncRoot;

    #endregion Public Properties

    #region Public Indexers

    public T this[int index] { get => ProxyValue[index]; set => ProxyValue[index] = value; }

    object IList.this[int index] {
      get => ((IList)ProxyValue)[index]; set => ((IList)ProxyValue)[index] = value;
    }

    #endregion Public Indexers

    #region Public Methods

    public void Add(T item) => ProxyValue.Add(item);

    public void Clear() => Values?.Clear();

    public bool Contains(T item) => Values?.Contains(item) ?? false;

    public IEnumerator<T> GetEnumerator() => ((IEnumerable<T>)Values)?.GetEnumerator() ?? Enumerable.Empty<T>().GetEnumerator();

    public int IndexOf(T item) => Values?.IndexOf(item) ?? -1;

    public void Insert(int index, T item) => ProxyValue.Insert(index, item);

    public bool Remove(T item) => Values?.Remove(item) ?? false;

    public void RemoveAt(int index) => Values?.RemoveAt(index);

    public int Add(object value) => ((IList)ProxyValue)?.Add(value) ?? -1;

    public bool Contains(object value) => ((IList)Values)?.Contains(value) ?? false;

    public int IndexOf(object value) => ((IList)Values)?.IndexOf(value) ?? -1;

    public void Insert(int index, object value) => ((IList)ProxyValue)?.Insert(index, value);

    public void Remove(object value) => ((IList)Values)?.Remove(value);

    public void CopyTo(T[] array, int arrayIndex) => Values?.CopyTo(array, arrayIndex);

    public void CopyTo(Array array, int index) => ((ICollection)Values)?.CopyTo(array, index);

    IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)Values)?.GetEnumerator() ?? Enumerable.Empty<T>().GetEnumerator();

    #endregion Public Methods

    #region Private Properties

    private List<T> ProxyValue {
      get {
        if (Values is null) {
          Values = new List<T>();
        }
        return Values;
      }
    }

    #endregion Private Properties
  }
}