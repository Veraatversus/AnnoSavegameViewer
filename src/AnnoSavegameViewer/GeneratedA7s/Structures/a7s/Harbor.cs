// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class Harbor {

		[BinaryContent(Name = "connected", NodeType = BinaryContentTypes.Attribute)]
		public HexString Connected { get; set; }

		[BinaryContent(Name = "boundingBox", NodeType = BinaryContentTypes.Attribute)]
		public HexString BoundingBox { get; set; }

		[BinaryContent(Name = "coastBoundingBox", NodeType = BinaryContentTypes.Attribute)]
		public HexString CoastBoundingBox { get; set; }

		[BinaryContent(Name = "coastLinePoints", NodeType = BinaryContentTypes.Node)]
		public CoastLinePoints CoastLinePoints { get; set; }

		[BinaryContent(Name = "driveways", NodeType = BinaryContentTypes.Node)]
		public Driveways Driveways { get; set; }

		[BinaryContent(Name = "buildings", NodeType = BinaryContentTypes.Node)]
		public Buildings Buildings { get; set; }

		[BinaryContent(Name = "buildingsPerGuid", NodeType = BinaryContentTypes.Node)]
		public BuildingsPerGuid BuildingsPerGuid { get; set; }

		[BinaryContent(Name = "defenses", NodeType = BinaryContentTypes.Node)]
		public Defenses Defenses { get; set; }

		[BinaryContent(Name = "harborOffices", NodeType = BinaryContentTypes.Node)]
		public HarborOffices HarborOffices { get; set; }

		[BinaryContent(Name = "unprotectedBuildings", NodeType = BinaryContentTypes.Attribute)]
		public HexString UnprotectedBuildings { get; set; }

		[BinaryContent(Name = "referencePos", NodeType = BinaryContentTypes.Attribute)]
		public HexString ReferencePos { get; set; }

		[BinaryContent(Name = "missingSecurity", NodeType = BinaryContentTypes.Attribute)]
		public HexString MissingSecurity { get; set; }

		[BinaryContent(Name = "totalNeededSecurity", NodeType = BinaryContentTypes.Attribute)]
		public HexString TotalNeededSecurity { get; set; }

		[BinaryContent(Name = "ID", NodeType = BinaryContentTypes.Attribute)]
		public HexString ID { get; set; }

		[BinaryContent(Name = "pierCount", NodeType = BinaryContentTypes.Attribute)]
		public HexString PierCount { get; set; }

		[BinaryContent(Name = "pierBuildingCount", NodeType = BinaryContentTypes.Attribute)]
		public HexString PierBuildingCount { get; set; }

	}
}
