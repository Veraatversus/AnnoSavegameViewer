// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace ClassCreator {
  using System;
  using System.Globalization;
  using System.Windows.Data;

  public class ClassNameConverter : IValueConverter {

    #region Public Methods

    public object Convert(object value, Type targetType, object parameter, CultureInfo culture) => value is Type type ? type.ToString().Replace($"{type.Namespace}", "").TrimStart('.') : null;

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => throw new NotImplementedException();

    #endregion Public Methods
  }
}