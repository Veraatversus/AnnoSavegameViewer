using AnnoSavegameViewer.Templates.Filters;

namespace AnnoSavegameViewer.Templates {

  public class BuildingsHolderItems : ItemsHolder {

    #region Public Constructors

    public BuildingsHolderItems() : base(() => ProgrammSettings.CurrentSavegame?.GameObjects?.GameObjects) {
      StandardFilters.Add("Player", new PlayerFilter(this));
      StandardFilters.Add("Session", new SessionsFilter(this));
      StandardFilters.Add("Area", new AreasFilter(this));
      StandardFilters.Add("Text", new SearchTextFilter(this));
    }

    #endregion Public Constructors
  }
}