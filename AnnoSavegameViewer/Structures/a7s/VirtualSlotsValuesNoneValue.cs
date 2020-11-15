namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class VirtualSlotsValuesNoneValue {

		[BinaryContent(Name = "OccupierID", NodeType = BinaryContentTypes.Attribute)]
		public HexString OccupierID { get; set; }

		[BinaryContent(Name = "AABB", NodeType = BinaryContentTypes.Attribute)]
		public HexString AABB { get; set; }

		[BinaryContent(Name = "Center", NodeType = BinaryContentTypes.Attribute)]
		public HexString Center { get; set; }

		[BinaryContent(Name = "Rotation", NodeType = BinaryContentTypes.Node)]
		public NoneRotation Rotation { get; set; }

	}
}
