namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class RequirementsList {

    [BinaryContent(Name = "Amount", NodeType = BinaryContentTypes.Attribute)]
    public object Amount { get; set; }

    [BinaryContent(Name = "Region", NodeType = BinaryContentTypes.Node)]
    public Region Region { get; set; }

    [BinaryContent(Name = "CivLevel", NodeType = BinaryContentTypes.Node)]
    public CivLevel CivLevel { get; set; }

  }
}