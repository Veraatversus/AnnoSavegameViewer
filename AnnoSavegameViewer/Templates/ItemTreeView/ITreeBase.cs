using AnnoSavegameViewer.Structures.Savegame;
using System;

namespace AnnoSavegameViewer.Templates {

  public interface ITreeBase {

    #region Public Properties

    int CountUnused { get; set; }
    int CountUsed { get; set; }
    Description Description { get; set; }
    Func<AnnoItem, Description> DescriptionSelector { get; }

    #endregion Public Properties

    #region Public Methods

    void Add(AnnoItem annoItem);

    #endregion Public Methods
  }
}