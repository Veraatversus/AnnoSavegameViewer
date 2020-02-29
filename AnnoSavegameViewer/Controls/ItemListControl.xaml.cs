using System.Collections;
using System.Windows;
using System.Windows.Controls;

namespace AnnoSavegameViewer.Controls {

  public partial class ItemListControl : UserControl {

    #region Public Properties

    public IEnumerable ItemSource {
      get { return (IEnumerable)GetValue(ItemSourceProperty); }
      set { SetValue(ItemSourceProperty, value); }
    }

    public int SelectedIndex {
      get { return (int)GetValue(SelectedIndexProperty); }
      set { SetValue(SelectedIndexProperty, value); }
    }

    #endregion Public Properties

    #region Public Fields

    public static readonly DependencyProperty ItemSourceProperty =
        DependencyProperty.Register("ItemSource", typeof(IEnumerable), typeof(ItemListControl), new PropertyMetadata(null));

    public static readonly DependencyProperty SelectedIndexProperty =
        DependencyProperty.Register("SelectedIndex", typeof(int), typeof(ItemListControl), new PropertyMetadata(0));

    #endregion Public Fields

    #region Public Constructors

    public ItemListControl() {
      InitializeComponent();
    }

    #endregion Public Constructors
  }
}