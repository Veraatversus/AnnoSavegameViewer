// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

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