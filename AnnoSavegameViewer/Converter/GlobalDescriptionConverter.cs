using System;
using System.Globalization;
using System.Windows.Data;

namespace AnnoSavegameViewer.Converter {

  public class GlobalDescriptionConverter : IValueConverter {

    #region Public Methods

    public Object Convert(Object value, Type targetType, Object parameter, CultureInfo culture) {
      if (parameter is int idint) {
        return ProgrammSettings.Texts.TryGetValue(idint, out var str) ? str : null;
      }
      else if (parameter is string idstring && int.TryParse(idstring, out var id)) {
        return ProgrammSettings.Texts.TryGetValue(id, out var str) ? str : null;
      }
      return null;
    }

    public Object ConvertBack(Object value, Type targetType, Object parameter, CultureInfo culture) {
      throw new NotImplementedException();
    }

    #endregion Public Methods
  }
}