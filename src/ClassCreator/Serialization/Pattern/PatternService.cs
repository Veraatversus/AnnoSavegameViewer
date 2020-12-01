// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace ClassCreator.Serialization.Pattern {

  using System;
  using System.Collections.Generic;
  using System.IO;
  using System.Linq;
  using System.Threading.Tasks;
  using AnnoSerializer.Serialization.Core;
  using ClassCreator.Serialization.CSharp;
  using ClassCreator.Serialization.Tree;
  using Newtonsoft.Json;

  public class PatternService {

    #region Public Properties

    public static PatternService Default { get; set; } = new PatternService();
    public string Name { get; set; }
    public Dictionary<ClassName, PropertyPattern> Patterns { get; set; } = new Dictionary<ClassName, PropertyPattern>();

    public CSharpClassDictionary Classes { get; } = new CSharpClassDictionary();

    #endregion Public Properties

    #region Public Methods

    public bool TryLoadPatterns(string pattern) {
      var patt = Path.GetExtension(pattern);
      patt = string.IsNullOrEmpty(patt) ? pattern.ToLower() : patt.TrimStart('.').ToLower();
      Patterns.Clear();
      Name = patt;
      if (File.Exists($"Patterns/{Name}.json")) {
        Patterns = JsonConvert.DeserializeObject<List<KeyValuePair<ClassName, PropertyPattern>>>(File.ReadAllText($"Patterns/{Name}.json")).ToDictionary(a=> a.Key, a=> a.Value);
        return true;
      }
      return false;
    }

    public void SavePatterns() {
      _ = Directory.CreateDirectory("Patterns");
      if (!string.IsNullOrEmpty(Name)) {
        File.WriteAllText($"Patterns/{Name}.json", JsonConvert.SerializeObject(Patterns.ToList()));
      }
    }

    public PropertyPattern SetPatternOrDefault(TreeNode node) {
      if (node.ClassName is not null) {
        if (!Patterns.TryGetValue(node.ClassName, out var propertyPattern)) {
          propertyPattern = GetDefaultPattern(node);
          Patterns.Add(propertyPattern.ClassName, propertyPattern);
        }
        if (!propertyPattern.IsRegistered) {
          propertyPattern.Attribute.PropertyChanged += propertyPattern.OnAttributePropertyChanged;
          propertyPattern.IsRegistered = true;
        }
        propertyPattern.RegisterNode(node);
        return propertyPattern;
      }
      return null;
    }

    public Task SaveCSharpClasses() {
      if (string.IsNullOrEmpty(Name)) {
        return Task.CompletedTask;
      }
      return Task.Run(() => {
        Classes.Clear();

        //Create Classes and Calculate Names
        foreach (var pattern in Patterns.Values.Where(a => a.Attribute.NodeType == BinaryContentTypes.Node || a.Attribute.ConversationType != ConversationTypes.None).OrderBy(a => a.ClassName.Count)) {
          Classes.Add(new CSharpClass() { Pattern = pattern });
        }

        //Fill Classes
        foreach (var csClass in Classes.Values.OrderByDescending(c => c.Pattern.ClassName.Count)) {
          //Standard Usings
          _ = csClass.Usings.Add("AnnoSerializer.Serialization.Core");
          _ = csClass.Usings.Add("AnnoSerializer.Structures.DataTypes");
          _ = csClass.Usings.Add("System");

          //Namespace
          csClass.Namespace = $"AnnoSerializer.Structures.Generated.{Name}";

          //Inheritances
          var childs = csClass.Pattern.Childs.ToList();
          var keys = childs.Find(p => p.RealName == "Keys" && p.IsArrayItem);
          var values = childs.Find(p => p.RealName == "Values" && p.IsArrayItem);
          if (keys != null || values != null) {
            var type = (keys, values) switch {
              (not null, not null) => $"KeyValueDictionary<{keys!.Childs.First().ToTypeString()}, {values.Childs.First().ToTypeString()}>",
              (not null, null) => $"KeysList<{keys.Childs.First().ToTypeString()}>",
              (null, not null) => $"ValuesList<{values.Childs.First().ToTypeString()}>"
            };

            csClass.Inheritances.Add(type);
            _ = csClass.Usings.Add("System.Collections.Generic");
          }

          //Propertys
          foreach (var pattern in csClass.Pattern.Childs) {
            var property = new CSharpProperty();

            var name = pattern.RealName;
            for (var i = 2; csClass.Propertys.Find(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase)) != default; i++) {
              name = pattern.RealName + i;
            }
            property.Name = name;

            property.Attribute = pattern.Attribute;
            property.Type = pattern.ToTypeString();
            csClass.Propertys.Add(property);
          }
        }

        //Save Files
        _ = Directory.CreateDirectory($"{Name}");
        foreach (var csClass in Classes.Values) {
          File.WriteAllText($"{Name}\\{csClass.Name}.cs", csClass.ToString());
        }

        Classes.Clear();
      });
    }

    #endregion Public Methods

    #region Private Methods

    private static PropertyPattern GetDefaultPattern(TreeNode node) {
      return new PropertyPattern {
        Attribute = new BinaryContentAttribute { Name = node.Name, NodeType = node.NodeType },
        ClassName = node.ClassName,
      };
    }

    #endregion Private Methods
  }
}