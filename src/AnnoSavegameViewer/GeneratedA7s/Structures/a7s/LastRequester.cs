// Copyright � 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class LastRequester {

		[BinaryContent(Name = "RequestType", NodeType = BinaryContentTypes.Node)]
		public LastRequesterRequestType RequestType { get; set; }

		[BinaryContent(Name = "Priority", NodeType = BinaryContentTypes.Node)]
		public LastRequesterPriority Priority { get; set; }

		[BinaryContent(Name = "ConstructionRequestSource", NodeType = BinaryContentTypes.Node)]
		public LastRequesterConstructionRequestSource ConstructionRequestSource { get; set; }

		[BinaryContent(Name = "OriginalRequestSource", NodeType = BinaryContentTypes.Node)]
		public LastRequesterOriginalRequestSource OriginalRequestSource { get; set; }

		[BinaryContent(Name = "ForceAreaID", NodeType = BinaryContentTypes.Attribute)]
		public HexString ForceAreaID { get; set; }

		[BinaryContent(Name = "BestAreaID", NodeType = BinaryContentTypes.Attribute)]
		public HexString BestAreaID { get; set; }

		[BinaryContent(Name = "BuildingGUID", NodeType = BinaryContentTypes.Attribute)]
		public HexString BuildingGUID { get; set; }

		[BinaryContent(Name = "CrafterGUID", NodeType = BinaryContentTypes.Attribute)]
		public HexString CrafterGUID { get; set; }

		[BinaryContent(Name = "Materials", NodeType = BinaryContentTypes.Node)]
		public LastRequesterMaterials Materials { get; set; }

		[BinaryContent(Name = "Budget", NodeType = BinaryContentTypes.Node)]
		public LastRequesterBudget Budget { get; set; }

	}
}
