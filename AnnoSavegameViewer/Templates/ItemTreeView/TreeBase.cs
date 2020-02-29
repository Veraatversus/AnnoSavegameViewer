using AnnoSavegameViewer.Comparer;
using AnnoSavegameViewer.Structures.Savegame;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace AnnoSavegameViewer.Templates {

  [DebuggerDisplay("{Description}")]
  public abstract class TreeBase<T> : IEnumerable<T>, ITreeBase where T : ITreeBase, new() {

    #region Public Properties

    public Description Description { get; set; }
    public Dictionary<Description, T> Items { get; set; } = new Dictionary<Description, T>(DescriptionComparer.Default);
    public int CountUsed { get; set; }
    public int CountUnused { get; set; }
    public abstract Func<AnnoItem, Description> DescriptionSelector { get; }

    #endregion Public Properties

    #region Public Methods

    public override string ToString() {
      return $"({CountUsed + CountUnused }/{CountUsed}/{CountUnused}) {Description}";
    }

    public void Add(AnnoItem annoItem) {
      if (annoItem.InUse)
        CountUsed += annoItem.Amount;
      else {
        CountUnused += annoItem.Amount;
      }
      var description = DescriptionSelector(annoItem);
      if (Items.TryGetValue(description, out var item)) {
        item.Add(annoItem);
      }
      else {
        item = new T();
        item.Description = description;
        item.Add(annoItem);
        Items.Add(description, item);
      }
    }

    public IEnumerator<T> GetEnumerator() {
      return Items.Values.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator() {
      return GetEnumerator();
    }

    #endregion Public Methods
  }
}