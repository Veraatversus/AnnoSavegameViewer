namespace AnnoSerializer.Structures.DataTypes {
  using AnnoSerializer.Serialization.Core;
  using System.Collections;
  using System.Collections.Generic;
  using System.Linq;

  public class GenericList<T> : IList<T> {

    #region Public Properties

    [BinaryContent(NodeType = BinaryContentTypes.Both)]
    public List<T> Items { get; set; }

    public int Count => Items.Count;
    public bool IsReadOnly => ((ICollection<T>)Items).IsReadOnly;

    #endregion Public Properties

    #region Public Indexers

    public T this[int index] { get => Items[index]; set => Items[index] = value; }

    #endregion Public Indexers

    #region Public Methods

    public void Add(T item) => Items.Add(item);

    public void Clear() => Items.Clear();

    public bool Contains(T item) => Items.Contains(item);

    public void CopyTo(T[] array, int arrayIndex) => Items.CopyTo(array, arrayIndex);

    public IEnumerator<T> GetEnumerator() => ((IEnumerable<T>)Items).GetEnumerator();

    public int IndexOf(T item) => Items.IndexOf(item);

    public void Insert(int index, T item) => Items.Insert(index, item);

    public bool Remove(T item) => Items.Remove(item);

    public void RemoveAt(int index) => Items.RemoveAt(index);

    public override string ToString() => string.Join(", ", Items.Select(i => i.ToString()));

    IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)Items).GetEnumerator();

    #endregion Public Methods
  }
}