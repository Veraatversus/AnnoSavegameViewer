// Copyright © 2020 Vera@Versus. All rights reserved.
// Licensed under the MIT License.

namespace ClassCreator {
  using System.Windows;
  using System.Windows.Controls;

  public static class TreeViewSelection {

    #region Public Methods

    public static bool GetIsSelectionEnabled(DependencyObject obj) => (bool)obj.GetValue(IsSelectionEnabledProperty);

    public static void SetIsSelectionEnabled(DependencyObject obj, bool value) => obj.SetValue(IsSelectionEnabledProperty, value);

    public static object GetSelectedItem(DependencyObject obj) => obj.GetValue(SelectedItemProperty);

    public static void SetSelectedItem(DependencyObject obj, object value) => obj.SetValue(SelectedItemProperty, value);

    #endregion Public Methods

    #region Public Fields

    // Using a DependencyProperty as the backing store for IsSelectionEnabled. This enables
    // animation, styling, binding, etc...
    public static readonly DependencyProperty IsSelectionEnabledProperty =
        DependencyProperty.RegisterAttached("IsSelectionEnabled", typeof(bool), typeof(TreeViewSelection), new FrameworkPropertyMetadata(false, IsSelectionEnabledChanged));

    // Using a DependencyProperty as the backing store for SelectedItem. This enables animation,
    // styling, binding, etc...
    public static readonly DependencyProperty SelectedItemProperty =
        DependencyProperty.RegisterAttached("SelectedItem", typeof(object), typeof(TreeViewSelection), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

    #endregion Public Fields

    #region Private Methods

    private static void IsSelectionEnabledChanged(DependencyObject d, DependencyPropertyChangedEventArgs e) {
      if (d is TreeView tv && e.NewValue is bool value) {
        if (value) {
          tv.SelectedItemChanged += TreeView_SelectedItemChanged;
        }
        else {
          tv.SelectedItemChanged -= TreeView_SelectedItemChanged;
        }
      }
    }

    private static void TreeView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e) {
      if (sender is DependencyObject dependencyObject) {
        SetSelectedItem(dependencyObject, e.NewValue);
      }
    }

    #endregion Private Methods
  }
}