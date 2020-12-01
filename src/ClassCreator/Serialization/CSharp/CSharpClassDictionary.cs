// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace ClassCreator.Serialization.CSharp {
  using AnnoSerializer.Serialization.Core;
  using ClassCreator.Serialization.Tree;
  using System.Collections;
  using System.Collections.Generic;
  using System.Diagnostics.CodeAnalysis;
  using System.Linq;

  public class CSharpClassDictionary : IDictionary<ClassName, CSharpClass> {

    #region Public Properties

    public ICollection<ClassName> Keys => ((IDictionary<ClassName, CSharpClass>)Classes).Keys;
    public ICollection<CSharpClass> Values => ((IDictionary<ClassName, CSharpClass>)Classes).Values;
    public int Count => Classes.Count;
    public bool IsReadOnly => ((ICollection<KeyValuePair<ClassName, CSharpClass>>)Classes).IsReadOnly;

    #endregion Public Properties

    #region Public Indexers

    public CSharpClass this[ClassName key] { get => Classes[key]; set => Classes[key] = value; }

    #endregion Public Indexers

    #region Public Methods

    public void Clear() {
      Classes.Clear();
      Names.Clear();
    }

    public void Add(CSharpClass value) => Add(value.Pattern.ClassName, value);

    public void Add(ClassName key, CSharpClass value) {
      SetUniqueClassName(value);
      Classes.Add(key, value);
    }

    public void Add(KeyValuePair<ClassName, CSharpClass> item) {
      SetUniqueClassName(item.Value);
      ((ICollection<KeyValuePair<ClassName, CSharpClass>>)Classes).Add(item);
    }

    public bool Contains(KeyValuePair<ClassName, CSharpClass> item) => ((ICollection<KeyValuePair<ClassName, CSharpClass>>)Classes).Contains(item);

    public bool ContainsKey(ClassName key) => Classes.ContainsKey(key);

    public void CopyTo(KeyValuePair<ClassName, CSharpClass>[] array, int arrayIndex) => ((ICollection<KeyValuePair<ClassName, CSharpClass>>)Classes).CopyTo(array, arrayIndex);

    public IEnumerator<KeyValuePair<ClassName, CSharpClass>> GetEnumerator() => ((IEnumerable<KeyValuePair<ClassName, CSharpClass>>)Classes).GetEnumerator();

    public bool Remove(ClassName key) => Classes.Remove(key);

    public bool Remove(KeyValuePair<ClassName, CSharpClass> item) => ((ICollection<KeyValuePair<ClassName, CSharpClass>>)Classes).Remove(item);

    public bool TryGetValue(ClassName key, [MaybeNullWhen(false)] out CSharpClass value) => Classes.TryGetValue(key, out value);

    IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)Classes).GetEnumerator();

    #endregion Public Methods

    #region Private Methods

    private void SetUniqueClassName(CSharpClass cSharpClass) {
      var names = cSharpClass.Pattern.ClassName.AsEnumerable().Reverse().ToArray();
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

    private readonly Dictionary<ClassName, CSharpClass> Classes = new Dictionary<ClassName, CSharpClass>();

    private readonly HashSet<string> Names = new HashSet<string>();

    #endregion Private Fields
  }
}