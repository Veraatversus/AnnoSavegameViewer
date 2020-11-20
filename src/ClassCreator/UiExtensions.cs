// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace ClassCreator {
  using System.Text.RegularExpressions;
  using System.Windows;
  using System.Windows.Controls;

  public static class UiExtensions {

    #region Public Methods

    public static bool GetIntegerOnly(this DependencyObject obj) => (bool)obj.GetValue(IntegerOnlyProperty);

    public static void SetIntegerOnly(this DependencyObject obj, bool value) => obj.SetValue(IntegerOnlyProperty, value);

    #endregion Public Methods

    #region Public Fields

    // Using a DependencyProperty as the backing store for MyProperty. This enables animation,
    // styling, binding, etc...
    public static readonly DependencyProperty IntegerOnlyProperty =
        DependencyProperty.RegisterAttached("IntegerOnly", typeof(bool), typeof(UiExtensions), new FrameworkPropertyMetadata(false, OnIntegerOnlyChanged));

    #endregion Public Fields

    #region Private Methods

    private static void OnIntegerOnlyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e) {
      if (d is TextBox box) {
        box.PreviewTextInput += Box_PreviewTextInput;
        DataObject.AddPastingHandler(d, TextBoxPasting);
      }
    }

    private static void Box_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e) => e.Handled = !IsTextAllowed(e.Text);

    private static bool IsTextAllowed(string text) => !_regex.IsMatch(text);

    private static void TextBoxPasting(object sender, DataObjectPastingEventArgs e) {
      if (e.DataObject.GetDataPresent(typeof(string))) {
        var text = (string)e.DataObject.GetData(typeof(string));
        if (!IsTextAllowed(text)) {
          e.CancelCommand();
        }
      }
      else {
        e.CancelCommand();
      }
    }

    #endregion Private Methods

    #region Private Fields

    private static readonly Regex _regex = new Regex("[^0-9.-]+");

    #endregion Private Fields
  }
}