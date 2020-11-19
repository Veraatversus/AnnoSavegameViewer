// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSavegameViewer.Converter {
  using System;
  using System.Collections.Generic;
  using System.Globalization;
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;
  using System.Windows.Data;
  using AnnoSavegameViewer.Templates;

  public class AmountConverter : IValueConverter {
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
      if (value is IGrouping<AnnoItem, AnnoItem> group) {
        return group.Sum(a => a.Amount);
      }
      return null;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => throw new NotImplementedException();
  }
}
