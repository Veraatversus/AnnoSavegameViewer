namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class OptimalAttackMovementData {

		[BinaryContent(Name = "OptimalAngleWS", NodeType = BinaryContentTypes.Attribute)]
		public HexString OptimalAngleWS { get; set; }

		[BinaryContent(Name = "OptimalDistanceWS", NodeType = BinaryContentTypes.Attribute)]
		public HexString OptimalDistanceWS { get; set; }

	}
}
