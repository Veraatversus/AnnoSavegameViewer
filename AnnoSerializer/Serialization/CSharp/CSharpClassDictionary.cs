namespace AnnoSerializer.Serialization.CSharp {
  using AnnoSerializer.Serialization.Core;
  using System.Collections;
  using System.Collections.Generic;
  using System.Diagnostics.CodeAnalysis;
  using System.Linq;

  public class CSharpClassDictionary : IDictionary<string, CSharpClass> {

    #region Public Properties

    public ICollection<string> Keys => ((IDictionary<string, CSharpClass>)Classes).Keys;
    public ICollection<CSharpClass> Values => ((IDictionary<string, CSharpClass>)Classes).Values;
    public int Count => Classes.Count;
    public bool IsReadOnly => ((ICollection<KeyValuePair<string, CSharpClass>>)Classes).IsReadOnly;

    #endregion Public Properties

    #region Public Indexers

    public CSharpClass this[string key] { get => Classes[key]; set => Classes[key] = value; }

    #endregion Public Indexers

    #region Public Methods

    public void Clear() {
      Classes.Clear();
      Names.Clear();
    }

    public void Add(CSharpClass value) => Add(value.Pattern.ClassName, value);

    public void Add(string key, CSharpClass value) {
      SetUniqueClassName(value);
      Classes.Add(key, value);
    }

    public void Add(KeyValuePair<string, CSharpClass> item) {
      SetUniqueClassName(item.Value);
      ((ICollection<KeyValuePair<string, CSharpClass>>)Classes).Add(item);
    }

    public bool Contains(KeyValuePair<string, CSharpClass> item) => ((ICollection<KeyValuePair<string, CSharpClass>>)Classes).Contains(item);

    public bool ContainsKey(string key) => Classes.ContainsKey(key);

    public void CopyTo(KeyValuePair<string, CSharpClass>[] array, int arrayIndex) => ((ICollection<KeyValuePair<string, CSharpClass>>)Classes).CopyTo(array, arrayIndex);

    public IEnumerator<KeyValuePair<string, CSharpClass>> GetEnumerator() => ((IEnumerable<KeyValuePair<string, CSharpClass>>)Classes).GetEnumerator();

    public bool Remove(string key) => Classes.Remove(key);

    public bool Remove(KeyValuePair<string, CSharpClass> item) => ((ICollection<KeyValuePair<string, CSharpClass>>)Classes).Remove(item);

    public bool TryGetValue(string key, [MaybeNullWhen(false)] out CSharpClass value) => Classes.TryGetValue(key, out value);

    IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)Classes).GetEnumerator();

    #endregion Public Methods

    #region Private Methods

    private void SetUniqueClassName(CSharpClass cSharpClass) {
      var names = cSharpClass.Pattern.ClassName.Split('.', System.StringSplitOptions.RemoveEmptyEntries).Reverse().ToArray();
      var name = "";

      //correct None Names
      if (names[0] == "None") {
        names[0] = cSharpClass.Pattern.Attribute.NodeType switch {
          BinaryContentTypes.Attribute => "Key",
          BinaryContentTypes.Node => "Value",
          _ => "None",
        };
        if (names.Length > 2) {
          names[1] = "";
        }
      }

      //find and set unique name
      for (var i = 0; i < names.Length; i++) {
        name = names[i].UppercaseFirst() + name;
        name = name.Replace(" ", "_");
        if (!Names.Contains(name.ToLower())) {
          cSharpClass.Name = name;
          _ = Names.Add(name.ToLower());

          return;
        }
      }
    }

    #endregion Private Methods

    #region Private Fields

    private readonly Dictionary<string, CSharpClass> Classes = new Dictionary<string, CSharpClass>();

    private readonly HashSet<string> Names = new HashSet<string>();

    #endregion Private Fields
  }
}