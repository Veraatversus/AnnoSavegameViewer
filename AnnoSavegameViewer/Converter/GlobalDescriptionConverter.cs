namespace AnnoSavegameViewer.Converter {
  using System;
  using System.Globalization;
  using System.Windows.Data;
  using AnnoSerializer;

  public class GlobalDescriptionConverter : IValueConverter {

    #region Public Methods

    public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
      if (parameter is int idint) {
        return LanguageService.Texts.TryGetValue(idint, out var str) ? str : null;
      }
      else if (parameter is string idstring && int.TryParse(idstring, out var id)) {
        return LanguageService.Texts.TryGetValue(id, out var str) ? str : null;
      }
      return null;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => throw new NotImplementedException();

    #endregion Public Methods
  }
}