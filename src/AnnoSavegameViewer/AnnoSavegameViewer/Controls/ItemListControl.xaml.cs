// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSavegameViewer.Controls {
  using System.Collections;
  using System.Windows;
  using System.Windows.Controls;

  public partial class ItemListControl : UserControl {

    #region Public Properties

    public IEnumerable ItemSource {
      get => (IEnumerable)GetValue(ItemSourceProperty);
      set => SetValue(ItemSourceProperty, value);
    }

    public int SelectedIndex {
      get => (int)GetValue(SelectedIndexProperty);
      set => SetValue(SelectedIndexProperty, value);
    }

    #endregion Public Properties

    #region Public Constructors

    public ItemListControl() => InitializeComponent();

    #endregion Public Constructors

    #region Public Fields

    public static readonly DependencyProperty ItemSourceProperty =
            DependencyProperty.Register("ItemSource", typeof(IEnumerable), typeof(ItemListControl), new PropertyMetadata(null));

    public static readonly DependencyProperty SelectedIndexProperty =
        DependencyProperty.Register("SelectedIndex", typeof(int), typeof(ItemListControl), new PropertyMetadata(0));

    #endregion Public Fields
  }
}