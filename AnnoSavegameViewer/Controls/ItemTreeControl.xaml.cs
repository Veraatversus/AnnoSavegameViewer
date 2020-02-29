using System.Windows.Controls;

namespace AnnoSavegameViewer.Controls {

  /// <summary>
  /// Interaktionslogik für ItemTreeControl.xaml
  /// </summary>
  public partial class ItemTreeControl : UserControl {

    #region Public Constructors

    public ItemTreeControl() {
      InitializeComponent();
    }

    #endregion Public Constructors

    //public void RaisePropertyChanged([CallerMemberName]string name = "") {
    //  PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    //}

    //public static readonly DependencyProperty SelectedItemProperty =
    //    DependencyProperty.Register("SelectedItem", typeof(AnnoItem), typeof(ItemTreeControl), new PropertyMetadata(null, OnSelectedItemChanged));
    //private TreeWorld treeItems;
    //public void RecreateTree() {
    //  if (DataContext is SavegameItemsViewModel model) {
    //    TreeItems = TreeWorld.Create(new DescriptionInt(-100030), model.ItemsHolder.Items);
    //  }
    //}
    //private static void OnSelectedItemChanged(DependencyObject d, DependencyPropertyChangedEventArgs e) {
    //  if (d is ItemTreeControl itemTree) {
    //    itemTree.RecreateTree();
    //  }

    //}
    //public TreeWorld TreeItems {
    //  get { return treeItems; }
    //  set {
    //    if (treeItems != value) {
    //      treeItems = value;
    //      RaisePropertyChanged(nameof(TreeItems));
    //    }
    //  }
    //}
  }
}