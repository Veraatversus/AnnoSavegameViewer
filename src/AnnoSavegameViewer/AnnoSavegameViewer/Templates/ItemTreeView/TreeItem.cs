// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSavegameViewer.Templates {
  using AnnoSerializer.Structures.DataTypes;
  using System;
  using System.Diagnostics;

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

    public override string ToString() => $"({CountUsed + CountUnused }/{CountUsed}/{CountUnused}) {Description}";

    public void Add(AnnoItem annoItem) {
      if (annoItem == null)
        throw new ArgumentNullException(nameof(annoItem));

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