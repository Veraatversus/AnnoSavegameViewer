namespace AnnoSavegameViewer.Templates.Filters {
  using AnnoSavegameViewer.Comparer;
  using AnnoSerializer.Structures.DataTypes;
  using System;
  using System.Collections.Generic;
  using System.Linq;

  public class OrderFilter : BaseFilter<Description> {

    #region Public Properties

    public override Func<IEnumerable<AnnoItem>, IEnumerable<AnnoItem>> FilterFunc => result => {
      if (SelectedValue != null && SelectedValue.GUID != 0) {
        if (SelectedValue.GUID == -100001) {
          result = result.OrderBy(w => w.GUID.CurrentLang);
        }
        else if (SelectedValue.GUID == -100002) {
          result = result.OrderBy(w => w.GUID.GUID);
        }
        else if (SelectedValue.GUID == -100003) {
          var tempresult = result.ToLookup(i => i, AnnoItemComparer.Default);
          result = result.OrderByDescending(w => tempresult[w].Count());
        }
      }

      return result;
    };

    public override int DescriptionID => -100014;

    public override List<Description> CurrentValues {
      get => currentValues;
      set {
        if (currentValues != value) {
          currentValues = value;
          RaisePropertyChanged();
        }
      }
    }

    public override Description SelectedValue {
      get => _selectedValue;
      set {
        if (!(_selectedValue?.Equals(value) ?? false)) {
          _selectedValue = value;
          RaisePropertyChanged();
        }
      }
    }

    #endregion Public Properties

    #region Public Constructors

    public OrderFilter(ItemsHolder itemsHolder) : base(itemsHolder) {
      CurrentValues = values;
      SelectedValue = values.FirstOrDefault();
    }

    #endregion Public Constructors

    #region Public Methods

    public override void ResetFilter() {
      CurrentValues = null;
      CurrentValues = values;
      SelectedValue = null;
      base.ResetFilter();
    }

    #endregion Public Methods

    #region Private Fields

    private readonly List<Description> values = new List<Description>{
      new DescriptionInt(-100001),
      new DescriptionInt(-100002),
      new DescriptionInt(-100003),
    };
    private Description _selectedValue;
    private List<Description> currentValues;

    #endregion Private Fields
  }
}