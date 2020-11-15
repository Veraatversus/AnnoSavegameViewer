namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class WaypointListValue {

		[BinaryContent(Name = "TargetObject", NodeType = BinaryContentTypes.Node)]
		public TargetObject TargetObject { get; set; }

		[BinaryContent(Name = "TimeToTarget", NodeType = BinaryContentTypes.Attribute)]
		public HexString TimeToTarget { get; set; }

	}
}
