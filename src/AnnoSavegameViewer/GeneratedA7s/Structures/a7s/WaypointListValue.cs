// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class WaypointListValue {

		[BinaryContent(Name = "TargetObject", NodeType = BinaryContentTypes.Node)]
		public TargetObject TargetObject { get; set; }

		[BinaryContent(Name = "TimeToTarget", NodeType = BinaryContentTypes.Attribute)]
		public HexString TimeToTarget { get; set; }

	}
}
