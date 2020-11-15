namespace AnnoSerializer.Structures.DataTypes {
  using AnnoSerializer.Serialization.Core;
  using System;
  using System.Collections;
  using System.Collections.Generic;
  using System.Linq;

  public abstract class KeysList<T> : IList<T>, IList {

		#region Public Properties

		[BinaryContent(Name = "None", NodeType = BinaryContentTypes.Attribute)]
		public abstract List<T> Keys { get; set; }

		public int Count => Keys?.Count ?? 0;
		public bool IsReadOnly => ((ICollection<T>)proxyValue).IsReadOnly;

		public bool IsFixedSize => ((IList)proxyValue).IsFixedSize;

		public bool IsSynchronized => ((ICollection)Keys)?.IsSynchronized ?? false;

		public object SyncRoot => ((ICollection)proxyValue).SyncRoot;

		#endregion Public Properties

		#region Public Indexers

		public T this[int index] { get => proxyValue[index]; set => proxyValue[index] = value; }
		object IList.this[int index] { get => ((IList)proxyValue)[index]; set => ((IList)proxyValue)[index] = value; }

    #endregion Public Indexers

    #region Public Methods

    public void Add(T item) => proxyValue.Add(item);

    public void Clear() => Keys?.Clear();

    public bool Contains(T item) => Keys?.Contains(item) ?? false;

    public void CopyTo(T[] array, int arrayIndex) => Keys?.CopyTo(array, arrayIndex);

    public IEnumerator<T> GetEnumerator() => ((IEnumerable<T>)Keys)?.GetEnumerator() ?? Enumerable.Empty<T>().GetEnumerator();

    public int IndexOf(T item) => Keys?.IndexOf(item) ?? -1;

    public void Insert(int index, T item) => proxyValue.Insert(index, item);

    public bool Remove(T item) => Keys?.Remove(item) ?? false;

    public void RemoveAt(int index) => Keys?.RemoveAt(index);

    public int Add(object value) => ((IList)proxyValue).Add(value);

    public bool Contains(object value) => ((IList)Keys)?.Contains(value) ?? false;

    public int IndexOf(object value) => ((IList)Keys)?.IndexOf(value) ?? -1;

    public void Insert(int index, object value) => ((IList)proxyValue).Insert(index, value);

    public void Remove(object value) => ((IList)Keys)?.Remove(value);

    public void CopyTo(Array array, int index) => ((ICollection)Keys)?.CopyTo(array, index);

    IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)Keys)?.GetEnumerator() ?? Enumerable.Empty<T>().GetEnumerator();

    #endregion Public Methods

    private List<T> proxyValue {
      get {
        if (Keys is null) {
          Keys = new List<T>();
        }
        return Keys;
      }
    }
  }
}