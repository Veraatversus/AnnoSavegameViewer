using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ConstructionQueue {

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

    [BinaryContent(Name = "PriorityHandler", NodeType = BinaryContentTypes.Node)]
    public PriorityHandler PriorityHandler { get; set; }

  }
}