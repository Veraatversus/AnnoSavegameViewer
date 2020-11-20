// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class HappinessData {

		[BinaryContent(Name = "owner", NodeType = BinaryContentTypes.Node)]
		public HappinessDataOwner Owner { get; set; }

		[BinaryContent(Name = "areaID", NodeType = BinaryContentTypes.Attribute)]
		public HexString AreaID { get; set; }

		[BinaryContent(Name = "avgHappiness", NodeType = BinaryContentTypes.Attribute)]
		public HexString AvgHappiness { get; set; }

		[BinaryContent(Name = "pollution", NodeType = BinaryContentTypes.Attribute)]
		public HexString Pollution { get; set; }

		[BinaryContent(Name = "warfare", NodeType = BinaryContentTypes.Attribute)]
		public HexString Warfare { get; set; }

		[BinaryContent(Name = "workingConditions", NodeType = BinaryContentTypes.Node)]
		public WorkingConditions WorkingConditions { get; set; }

	}
}
