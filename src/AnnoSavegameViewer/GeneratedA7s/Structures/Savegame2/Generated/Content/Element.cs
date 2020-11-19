namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class Element {

    #region Public Properties

    [BinaryContent(Name = "Data", NodeType = BinaryContentTypes.Attribute)]
    public object Data { get; set; }

    [BinaryContent(Name = "ID", NodeType = BinaryContentTypes.Attribute)]
    public object ID { get; set; }

    [BinaryContent(Name = "Time", NodeType = BinaryContentTypes.Attribute)]
    public object Time { get; set; }

    [BinaryContent(Name = "Delta", NodeType = BinaryContentTypes.Attribute)]
    public object Delta { get; set; }

    #endregion Public Properties
  }
}