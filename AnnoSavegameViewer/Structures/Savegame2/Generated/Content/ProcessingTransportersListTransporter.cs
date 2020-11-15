namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class ProcessingTransportersListTransporter {

    [BinaryContent(Name = "Type", NodeType = BinaryContentTypes.Attribute)]
    public object Type { get; set; }

    [BinaryContent(Name = "Index", NodeType = BinaryContentTypes.Attribute)]
    public object Index { get; set; }

    [BinaryContent(Name = "Parent", NodeType = BinaryContentTypes.Node)]
    public ProcessingTransportersListTransporterParent Parent { get; set; }

  }
}