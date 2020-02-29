using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ConstructionQueue {

    #region Public Properties

    [BinaryContent(Name = "LastBuildTime", NodeType = BinaryContentTypes.Attribute)]
    public object LastBuildTime { get; set; }

    [BinaryContent(Name = "MilitaryWasCraftable", NodeType = BinaryContentTypes.Attribute)]
    public object MilitaryWasCraftable { get; set; }

    [BinaryContent(Name = "Requests", NodeType = BinaryContentTypes.Node)]
    public ConstructionQueueRequests Requests { get; set; }

    [BinaryContent(Name = "MetaRequestsFromOutside", NodeType = BinaryContentTypes.Node)]
    public MetaRequestsFromOutside MetaRequestsFromOutside { get; set; }

    [BinaryContent(Name = "MetaRequestsToOutside", NodeType = BinaryContentTypes.Node)]
    public MetaRequestsToOutside MetaRequestsToOutside { get; set; }

    [BinaryContent(Name = "MetaRequestsToOutsideD", NodeType = BinaryContentTypes.Node)]
    public MetaRequestsToOutsideD MetaRequestsToOutsideD { get; set; }

    [BinaryContent(Name = "SoftRequiredMaterials", NodeType = BinaryContentTypes.Node)]
    public SoftRequiredMaterials SoftRequiredMaterials { get; set; }

    #endregion Public Properties
  }
}