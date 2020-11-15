namespace AnnoSavegameViewer.Structures.DataTypes {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class GenericDictionary<TKey, TValue> /*: IDictionary<TKey, TValue>*/ {

    #region Public Properties

    [BinaryContent(NodeType = BinaryContentTypes.Both)]
    public List<TKey> Keys { get; set; }

    [BinaryContent(NodeType = BinaryContentTypes.Both)]
    public List<TValue> Values { get; set; }

    #endregion Public Properties
  }
}