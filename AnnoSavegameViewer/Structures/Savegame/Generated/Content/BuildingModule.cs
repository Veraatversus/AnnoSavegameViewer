using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class BuildingModule {

    #region Public Properties

    [BinaryContent(Name = "ParentFactoryID", NodeType = BinaryContentTypes.Attribute)]
    public object ParentFactoryID { get; set; }

    [BinaryContent(Name = "CultureSlotIndex", NodeType = BinaryContentTypes.Attribute)]
    public object CultureSlotIndex { get; set; }

    #endregion Public Properties
  }
}