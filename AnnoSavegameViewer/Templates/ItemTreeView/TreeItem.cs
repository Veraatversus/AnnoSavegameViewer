using AnnoSavegameViewer.Structures.Savegame;
using System;
using System.Diagnostics;

namespace AnnoSavegameViewer.Templates {

  [DebuggerDisplay("{Description}")]
  public class TreeItem : ITreeBase {

    #region Public Properties

    public int CountUnused { get; set; }
    public int CountUsed { get; set; }
    public Description Description { get; set; }
    public AnnoItem Item { get; set; }

    public Func<AnnoItem, Description> DescriptionSelector => throw new NotImplementedException();

    #endregion Public Properties

    #region Public Methods

    public override string ToString() {
      return $"({CountUsed + CountUnused }/{CountUsed}/{CountUnused}) {Description}";
    }

    public void Add(AnnoItem annoItem) {
      Item = annoItem;
      if (Item.InUse) {
        CountUsed += annoItem.Amount;
      }
      else {
        CountUnused += annoItem.Amount;
      }
    }

    #endregion Public Methods
  }
}