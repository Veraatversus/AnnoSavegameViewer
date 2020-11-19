﻿// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSavegameViewer.Templates {
  using AnnoSavegameViewer.Comparer;
  using AnnoSavegameViewer.Templates.Filters;
  using System;
  using System.Collections.Generic;
  using System.ComponentModel;
  using System.Linq;
  using System.Runtime.CompilerServices;

  public abstract class ItemsHolder : INotifyPropertyChanged {

    #region Public Properties

    public IFilter OrderFilter { get; }
    public Dictionary<string, IFilter> StandardFilters { get; } = new Dictionary<string, IFilter>();
    public Func<IEnumerable<AnnoItem>> BaseFunc { get; set; }
    public IEnumerable<AnnoItem> Base => BaseFunc?.Invoke() ?? Enumerable.Empty<AnnoItem>();
    public ILookup<AnnoItem, AnnoItem> Items { get; set; }

    public TreeWorld[] SelectedItemTree {
      get => selectedItemTree;
      set {
        if (selectedItemTree != value) {
          selectedItemTree = value;
          RaisePropertyChanged(nameof(SelectedItemTree));
        }
      }
    }

    public bool IsRefreshingUi { get; set; } = false;

    #endregion Public Properties

    #region Public Events

    public event PropertyChangedEventHandler PropertyChanged;

    #endregion Public Events

    #region Public Methods

    public void UpdateUI(IFilter filter = null) {
      if (!IsRefreshingUi) {
        IsRefreshingUi = true;
        SetItems();
        this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Items)));
        foreach (var item in StandardFilters.Values.Except(new[] { filter })) {
          item.UpdateUI();
        }
        OrderFilter.UpdateUI();
        IsRefreshingUi = false;
      }
    }

    public void SetItems() => Items = OrderFilter.FilterFunc(GetResultWithoutFilter<IFilter>(null)).ToLookup(i => i, AnnoItemComparer.Default);

    public void UpdadeSavedItems() {
      IsRefreshingUi = true;
      foreach (var filter in StandardFilters.Values) {
        filter.UpdateSavedItems();
      }
      OrderFilter.ResetFilter();
      IsRefreshingUi = false;
      UpdateUI();
    }

    public IEnumerable<AnnoItem> GetResultWithoutFilter<T>(IFilter<T> filter) {
      var result = Base;
      foreach (var f in StandardFilters.Values.Except(new[] { filter })) {
        if (f.SavedItems != null) {
          result = result == null ? f.SavedItems : result.Intersect(f.SavedItems);
        }
      }
      return (result?.Distinct()) ?? Base;
    }

    public void ResetFilters() {
      IsRefreshingUi = true;
      foreach (var filter in StandardFilters.Values) {
        filter.ResetFilter();
      }
      OrderFilter.ResetFilter();
      IsRefreshingUi = false;
      UpdateUI();
    }

    public void RaisePropertyChanged([CallerMemberName] string name = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

    #endregion Public Methods

    #region Protected Constructors

    protected ItemsHolder(Func<IEnumerable<AnnoItem>> Base) {
      this.BaseFunc = Base;
      OrderFilter = new OrderFilter(this);
    }

    #endregion Protected Constructors

    #region Private Fields

    private TreeWorld[] selectedItemTree;

    #endregion Private Fields
  }
}