namespace test {
  using AnnoSavegameViewer.Serialization;
  using AnnoSavegameViewer.Structures.a7s.Generated;
  using System;
  using System.Threading.Tasks;

  internal class Program {

    #region Private Methods

    private async static Task Main(string[] _) {
      Console.WriteLine("Hello World!");
			var a7s = await AnnoFileSerializer.ReadFileAsync<A7s_File>("Autosave 12.a7s");
      var savenametest= a7s.A7s_File_RDA.Block_00.Meta_a7s.CorporationSaveGameName;
    }

    #endregion Private Methods
  }
}