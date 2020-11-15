namespace FileDBReader {
  using System;

  public static class Program {

    #region Private Methods

    [STAThread]
    private static void Main() {
      var app = new AnnoSavegameViewer.App();
      app.InitializeComponent();
      _ = app.Run();
    }

    #endregion Private Methods
  }
}