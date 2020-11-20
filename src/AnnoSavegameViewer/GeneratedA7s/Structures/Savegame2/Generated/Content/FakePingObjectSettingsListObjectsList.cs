namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class FakePingObjectSettingsListObjectsList {

    #region Public Properties

    [BinaryContent(Name = "ObjectID", NodeType = BinaryContentTypes.Attribute)]
    public object ObjectID { get; set; }

    [BinaryContent(Name = "CargoItems", NodeType = BinaryContentTypes.Node)]
    public FakePingObjectSettingsListObjectsListCargoItems CargoItems { get; set; }

    #endregion Public Properties
  }
}