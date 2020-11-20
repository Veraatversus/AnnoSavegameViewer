namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class LastCameraStateProjection {

    [BinaryContent(Name = "Flags", NodeType = BinaryContentTypes.Attribute)]
    public object Flags { get; set; }

    [BinaryContent(Name = "FOV", NodeType = BinaryContentTypes.Attribute)]
    public object FOV { get; set; }

    [BinaryContent(Name = "NearClip", NodeType = BinaryContentTypes.Attribute)]
    public object NearClip { get; set; }

    [BinaryContent(Name = "FarClip", NodeType = BinaryContentTypes.Attribute)]
    public object FarClip { get; set; }

    [BinaryContent(Name = "AspectRatio", NodeType = BinaryContentTypes.Attribute)]
    public object AspectRatio { get; set; }
  }
}