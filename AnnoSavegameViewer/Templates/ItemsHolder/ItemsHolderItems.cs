using AnnoSavegameViewer.Templates.Filters;

namespace AnnoSavegameViewer.Templates {

  public class ItemsHolderItems : ItemsHolder {

    #region Public Constructors

    public ItemsHolderItems() : base(() => ProgrammSettings.CurrentSavegame?.GameObjects?.Items) {
      StandardFilters.Add("Player", new PlayerFilter(this));
      StandardFilters.Add("Session", new SessionsFilter(this));
      StandardFilters.Add("Area", new AreasFilter(this));
      StandardFilters.Add("Text", new SearchTextFilter(this));
    }

    #endregion Public Constructors
  }
}