// Copyright � 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class ConstructionQueueRequestsValue {

		[BinaryContent(Name = "RequestType", NodeType = BinaryContentTypes.Node)]
		public RequestType RequestType { get; set; }

		[BinaryContent(Name = "Priority", NodeType = BinaryContentTypes.Node)]
		public ValuesNonePriority Priority { get; set; }

		[BinaryContent(Name = "ScndPriority", NodeType = BinaryContentTypes.Attribute)]
		public HexString ScndPriority { get; set; }

		[BinaryContent(Name = "ConstructionRequestSource", NodeType = BinaryContentTypes.Node)]
		public ConstructionRequestSource ConstructionRequestSource { get; set; }

		[BinaryContent(Name = "OriginalRequestSource", NodeType = BinaryContentTypes.Node)]
		public OriginalRequestSource OriginalRequestSource { get; set; }

		[BinaryContent(Name = "ForceAreaID", NodeType = BinaryContentTypes.Attribute)]
		public HexString ForceAreaID { get; set; }

		[BinaryContent(Name = "BestAreaID", NodeType = BinaryContentTypes.Attribute)]
		public HexString BestAreaID { get; set; }

		[BinaryContent(Name = "BuildingGUID", NodeType = BinaryContentTypes.Attribute)]
		public HexString BuildingGUID { get; set; }

		[BinaryContent(Name = "CrafterGUID", NodeType = BinaryContentTypes.Attribute)]
		public HexString CrafterGUID { get; set; }

		[BinaryContent(Name = "Materials", NodeType = BinaryContentTypes.Node)]
		public Materials Materials { get; set; }

		[BinaryContent(Name = "Budget", NodeType = BinaryContentTypes.Node)]
		public Budget Budget { get; set; }

	}
}
