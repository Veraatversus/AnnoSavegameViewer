// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class Attacker {

		[BinaryContent(Name = "Turrets", NodeType = BinaryContentTypes.Node)]
		public Turrets Turrets { get; set; }

		[BinaryContent(Name = "AutoAttackID", NodeType = BinaryContentTypes.Attribute)]
		public HexString AutoAttackID { get; set; }

		[BinaryContent(Name = "FirePerSide", NodeType = BinaryContentTypes.Attribute)]
		public HexString FirePerSide { get; set; }

		[BinaryContent(Name = "FutureBorrowedShots", NodeType = BinaryContentTypes.Attribute)]
		public HexString FutureBorrowedShots { get; set; }

		[BinaryContent(Name = "ProjectileLaunchinformation", NodeType = BinaryContentTypes.Node)]
		public ProjectileLaunchinformation ProjectileLaunchinformation { get; set; }

		[BinaryContent(Name = "IsBlinded", NodeType = BinaryContentTypes.Attribute)]
		public HexString IsBlinded { get; set; }

	}
}
