// Copyright � 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class ConstructionAIConstructionQueue {

		[BinaryContent(Name = "Requests", NodeType = BinaryContentTypes.Node)]
		public ConstructionQueueRequests Requests { get; set; }

		[BinaryContent(Name = "MetaRequestsFromOutside", NodeType = BinaryContentTypes.Node)]
		public MetaRequestsFromOutside MetaRequestsFromOutside { get; set; }

		[BinaryContent(Name = "MetaRequestsToOutside", NodeType = BinaryContentTypes.Node)]
		public MetaRequestsToOutside MetaRequestsToOutside { get; set; }

		[BinaryContent(Name = "MetaRequestsToOutsideD", NodeType = BinaryContentTypes.Node)]
		public MetaRequestsToOutsideD MetaRequestsToOutsideD { get; set; }

		[BinaryContent(Name = "LastBuildTime", NodeType = BinaryContentTypes.Attribute)]
		public HexString LastBuildTime { get; set; }

		[BinaryContent(Name = "SoftRequiredMaterials", NodeType = BinaryContentTypes.Node)]
		public SoftRequiredMaterials SoftRequiredMaterials { get; set; }

		[BinaryContent(Name = "MilitaryWasCraftable", NodeType = BinaryContentTypes.Attribute)]
		public HexString MilitaryWasCraftable { get; set; }

		[BinaryContent(Name = "PriorityHandler", NodeType = BinaryContentTypes.Node)]
		public PriorityHandler PriorityHandler { get; set; }

	}
}
