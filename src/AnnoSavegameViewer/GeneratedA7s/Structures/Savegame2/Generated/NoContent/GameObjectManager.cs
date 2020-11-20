namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class GameObjectManager {

    [BinaryContent(Name = "GameObjectLabelMap", NodeType = BinaryContentTypes.Node)]
    public GameObjectLabelMap GameObjectLabelMap { get; set; }

    [BinaryContent(Name = "DynamicObjectGroupCollection", NodeType = BinaryContentTypes.Node)]
    public DynamicObjectGroupCollection DynamicObjectGroupCollection { get; set; }

  }
}