// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace ClassCreator {
  using System.Windows;
  using System.Windows.Controls;
  using ClassCreator.Serialization.Pattern;

  /// <summary>
  /// Interaktionslogik für AttributeControl.xaml
  /// </summary>
  public partial class AttributeControl : UserControl {
    public AttributeControl() => InitializeComponent();



    public PropertyPattern SelectedPattern {
      get => (PropertyPattern)GetValue(SelectedPatternProperty);
      set => SetValue(SelectedPatternProperty, value);
    }

    // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
    public static readonly DependencyProperty SelectedPatternProperty =
        DependencyProperty.Register("SelectedPattern", typeof(PropertyPattern), typeof(AttributeControl), new PropertyMetadata(null));


  }
}
