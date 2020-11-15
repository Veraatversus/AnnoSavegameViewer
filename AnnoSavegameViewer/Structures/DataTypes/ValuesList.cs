namespace AnnoSavegameViewer.Structures.DataTypes {
  using AnnoSavegameViewer.Serialization.Core;
  using System;
  using System.Collections;
  using System.Collections.Generic;

  public abstract class ValuesList<T> : IList<T>, IList {

		#region Public Properties

		[BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
		public abstract List<T> Values { get; set; }

		public int Count => Values.Count;

		public bool IsReadOnly => ((ICollection<T>)Values).IsReadOnly;

		public bool IsFixedSize => ((IList)Values).IsFixedSize;

		public bool IsSynchronized => ((ICollection)Values).IsSynchronized;

		public object SyncRoot => ((ICollection)Values).SyncRoot;

		#endregion Public Properties

		#region Public Indexers

		public T this[int index] { get => Values[index]; set => Values[index] = value; }
		object IList.this[int index] { get => ((IList)Values)[index]; set => ((IList)Values)[index] = value; }

    #endregion Public Indexers

    #region Public Methods

    public void Add(T item) => Values.Add(item);

    public void Clear() => Values.Clear();

    public bool Contains(T item) => Values.Contains(item);

    public void CopyTo(T[] array, int arrayIndex) => Values.CopyTo(array, arrayIndex);

    public IEnumerator<T> GetEnumerator() => ((IEnumerable<T>)Values).GetEnumerator();

    public int IndexOf(T item) => Values.IndexOf(item);

    public void Insert(int index, T item) => Values.Insert(index, item);

    public bool Remove(T item) => Values.Remove(item);

    public void RemoveAt(int index) => Values.RemoveAt(index);

    public int Add(object value) => ((IList)Values).Add(value);

    public bool Contains(object value) => ((IList)Values).Contains(value);

    public int IndexOf(object value) => ((IList)Values).IndexOf(value);

    public void Insert(int index, object value) => ((IList)Values).Insert(index, value);

    public void Remove(object value) => ((IList)Values).Remove(value);

    public void CopyTo(Array array, int index) => ((ICollection)Values).CopyTo(array, index);

    IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)Values).GetEnumerator();

    #endregion Public Methods
  }
}