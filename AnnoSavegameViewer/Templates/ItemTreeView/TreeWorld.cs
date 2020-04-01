using AnnoSavegameViewer.Structures.Savegame;
using System;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Templates {

  public class TreeWorld : TreeBase<TreeSession> {

    #region Public Properties

    public override Func<AnnoItem, Description> DescriptionSelector => item => item.Session.SessionDesc.SessionGUID;

    #endregion Public Properties

    #region Public Methods

    public static TreeWorld Create(Description description, IEnumerable<AnnoItem> items) {
      var world = new TreeWorld { Description = description };
      if (items != null) {
        foreach (var item in items) {
          world.Add(item);
        }
      }
      return world;
    }

    #endregion Public Methods

    //public IEnumerator<ITreeBase> GetEnumerator() {
    //  yield return this;
    //  foreach (var item in Items.Values) {
    //    yield return item;
    //  }
    //}
    //IEnumerator IEnumerable.GetEnumerator() {
    //  return GetEnumerator();
    //}
  }
}