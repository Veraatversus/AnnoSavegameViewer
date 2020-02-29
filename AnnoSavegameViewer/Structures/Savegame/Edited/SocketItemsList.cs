using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class SocketItemsList {

    #region Public Properties

    [BinaryContent(Name = "ActivationTime", NodeType = BinaryContentTypes.Attribute)]
    public object ActivationTime { get; set; }

    [BinaryContent(Name = "GUID", NodeType = BinaryContentTypes.Attribute)]
    public DescriptionInt GUID { get; set; }

    [BinaryContent(Name = "IsActivated", NodeType = BinaryContentTypes.Attribute)]
    public object IsActivated { get; set; }

    [BinaryContent(Name = "ItemReference", NodeType = BinaryContentTypes.Node)]
    public ItemReference ItemReference { get; set; }

    #endregion Public Properties
  }
}