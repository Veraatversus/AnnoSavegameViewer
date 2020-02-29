using System.Windows;

namespace AnnoSavegameViewer.Controls.Loading {

  /// <summary>
  /// Interaktionslogik für LoadingDialog.xaml
  /// </summary>
  public partial class LoadingDialog : Window {

    #region Public Constructors

    public LoadingDialog() {
      InitializeComponent();
      Loaded += LoadingDialog_Loaded;
    }

    #endregion Public Constructors

    #region Private Methods

    private void LoadingDialog_Loaded(object sender, RoutedEventArgs e) {
      this.Visibility = Visibility.Visible;
    }

    #endregion Private Methods
  }
}