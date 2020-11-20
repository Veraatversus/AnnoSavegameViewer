namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using AnnoSavegameViewer.Structures.DataTypes;

  public class SessionDesc {

    #region Public Properties

    [BinaryContent(Name = "SessionGUID", NodeType = BinaryContentTypes.Attribute)]
    public DescriptionInt SessionGUID { get; set; }

    [BinaryContent(Name = "SessionID", NodeType = BinaryContentTypes.Attribute)]
    public short SessionID { get; set; }

    [BinaryContent(Name = "SessionMap", Encoding = "utf-16", NodeType = BinaryContentTypes.Attribute)]
    public string SessionMap { get; set; }

    [BinaryContent(Name = "MapGeneratorSettings", NodeType = BinaryContentTypes.Node)]
    public MapGeneratorSettings MapGeneratorSettings { get; set; }

    #endregion Public Properties
  }
}