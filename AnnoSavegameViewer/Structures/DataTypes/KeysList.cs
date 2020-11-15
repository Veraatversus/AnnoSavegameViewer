namespace AnnoSavegameViewer.Structures.DataTypes {
  using AnnoSavegameViewer.Serialization.Core;
  using System;
  using System.Collections;
  using System.Collections.Generic;

  public abstract class KeysList<T> : IList<T>, IList {

		#region Public Properties

		[BinaryContent(Name = "None", NodeType = BinaryContentTypes.Attribute)]
		public abstract List<T> Keys { get; set; }

		public int Count => Keys.Count;
		public bool IsReadOnly => ((ICollection<T>)Keys).IsReadOnly;

		public bool IsFixedSize => ((IList)Keys).IsFixedSize;

		public bool IsSynchronized => ((ICollection)Keys).IsSynchronized;

		public object SyncRoot => ((ICollection)Keys).SyncRoot;

		#endregion Public Properties

		#region Public Indexers

		public T this[int index] { get => Keys[index]; set => Keys[index] = value; }
		object IList.this[int index] { get => ((IList)Keys)[index]; set => ((IList)Keys)[index] = value; }

    #endregion Public Indexers

    #region Public Methods

    public void Add(T item) => Keys.Add(item);

    public void Clear() => Keys.Clear();

    public bool Contains(T item) => Keys.Contains(item);

    public void CopyTo(T[] array, int arrayIndex) => Keys.CopyTo(array, arrayIndex);

    public IEnumerator<T> GetEnumerator() => ((IEnumerable<T>)Keys).GetEnumerator();

    public int IndexOf(T item) => Keys.IndexOf(item);

    public void Insert(int index, T item) => Keys.Insert(index, item);

    public bool Remove(T item) => Keys.Remove(item);

    public void RemoveAt(int index) => Keys.RemoveAt(index);

    public int Add(object value) => ((IList)Keys).Add(value);

    public bool Contains(object value) => ((IList)Keys).Contains(value);

    public int IndexOf(object value) => ((IList)Keys).IndexOf(value);

    public void Insert(int index, object value) => ((IList)Keys).Insert(index, value);

    public void Remove(object value) => ((IList)Keys).Remove(value);

    public void CopyTo(Array array, int index) => ((ICollection)Keys).CopyTo(array, index);

    IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)Keys).GetEnumerator();

    #endregion Public Methods
  }
}