using System.Windows;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AnnoRdaExtractInsert {
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window {
    public MainWindow() {
      InitializeComponent();
      Loaded += MainWindow_Loaded;
    }

    private void MainWindow_Loaded(object sender, RoutedEventArgs e) {
      //CompressionHelper.DecompressFromFile("moderate_atoll_ll_01.a7t", 792, 325162);
      //MessageBox.Show("Please edit the bytes file than press ok.");
      CompressionHelper.InsertBlockCompressed("moderate_atoll_ll_01.a7t", 792, 325162);
    }
  }
}
