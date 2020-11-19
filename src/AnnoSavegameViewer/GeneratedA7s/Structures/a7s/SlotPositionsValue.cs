// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class SlotPositionsValue {

		[BinaryContent(Name = "Position", NodeType = BinaryContentTypes.Attribute)]
		public HexString Position { get; set; }

		[BinaryContent(Name = "Rotation", NodeType = BinaryContentTypes.Node)]
		public Rotation Rotation { get; set; }

		[BinaryContent(Name = "ObjectID", NodeType = BinaryContentTypes.Attribute)]
		public HexString ObjectID { get; set; }

		[BinaryContent(Name = "OccupierID", NodeType = BinaryContentTypes.Attribute)]
		public HexString OccupierID { get; set; }

		[BinaryContent(Name = "SlotType", NodeType = BinaryContentTypes.Node)]
		public SlotType SlotType { get; set; }

		[BinaryContent(Name = "AABB", NodeType = BinaryContentTypes.Attribute)]
		public HexString AABB { get; set; }

	}
}
