// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace ClassCreator.Serialization.CSharp {
  using AnnoSerializer.Serialization.Core;
  using ClassCreator.Serialization.Pattern;
  using System;
  using System.Collections.Generic;
  using System.Linq;

  public static class CSharpExtensions {

    #region Public Methods

    public static string ToTypeString(this PropertyPattern pattern) {
      if (pattern.IsArrayItem) {
        return pattern.RealName is "Keys" or "Values"
          ? $"override {nameof(List<int>)}<{pattern.Childs.First().ToTypeString()}>"
          : throw new NotImplementedException();
      }
      else {
        return pattern.Class is CSharpClass cSharpClass ? cSharpClass.Name : pattern.FullType.ToTypeString();
      }
    }

    #endregion Public Methods
  }
}