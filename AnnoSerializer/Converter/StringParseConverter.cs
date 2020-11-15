namespace AnnoSerializer.Converter {
  using AnnoSerializer.Serialization.Tree;
  using System;
  using System.Globalization;
  using System.Reflection;
  using System.Windows;
  //using System.Windows.Data;

  public class StringParseConverter /*: IValueConverter*/ {

    #region Public Methods

    public static object TryParse(object o, Type targetType, CultureInfo culture) {
      //var result = DependencyProperty.UnsetValue;
      object result = null;

      if (o is string stringValue) {
        try {
          MethodInfo mi;

          if (culture != null && (mi = targetType.GetMethod("Parse",
                                  BindingFlags.Public | BindingFlags.Static,
                                  null,
                                  new Type[] { StringType, typeof(System.Globalization.NumberStyles), typeof(System.IFormatProvider) },
                                  null))
                      != null) {
            result = mi.Invoke(null, new object[] { stringValue, NumberStyles.Any, culture });
          }
          else if (culture != null && (mi = targetType.GetMethod("Parse",
                                  BindingFlags.Public | BindingFlags.Static,
                                  null,
                                  new Type[] { StringType, typeof(System.IFormatProvider) },
                                  null))
                      != null) {
            result = mi.Invoke(null, new object[] { stringValue, culture });
          }
          else if ((mi = targetType.GetMethod("Parse",
                                  BindingFlags.Public | BindingFlags.Static,
                                  null,
                                  new Type[] { StringType },
                                  null))
                      != null) {
            result = mi.Invoke(null, new object[] { stringValue });
          }
        }
        catch (Exception) {
          //Parsing failed. return default value
          return result;
        }
      }

      return result;
    }

    public object Convert(object value, Type targetType, object parameter, CultureInfo culture) => value is TreeNode node ? (node?.CalculatedValue?.ToString()) : (value?.ToString());

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => parameter is Type type ? TryParse(value, type, culture) : null;

    #endregion Public Methods

    #region Private Fields

    private static readonly Type StringType = typeof(string);

    #endregion Private Fields
  }
}