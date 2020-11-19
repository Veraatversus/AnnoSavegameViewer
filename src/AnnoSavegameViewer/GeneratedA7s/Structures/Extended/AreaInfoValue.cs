// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;
  using AnnoSerializer.Structures.DataTypes;

  public partial class AreaInfoValue {
    public Description CityDescription => string.IsNullOrEmpty(CityName) ? CityNameGuid : new Description(CityName);
  }
}
