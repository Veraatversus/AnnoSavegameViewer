// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class IslandRatingsValue {

		[BinaryContent(Name = "AreaID", NodeType = BinaryContentTypes.Attribute)]
		public HexString AreaID { get; set; }

		[BinaryContent(Name = "Category", NodeType = BinaryContentTypes.Attribute)]
		public HexString Category { get; set; }

		[BinaryContent(Name = "Priority", NodeType = BinaryContentTypes.Attribute)]
		public HexString Priority { get; set; }

	}
}
