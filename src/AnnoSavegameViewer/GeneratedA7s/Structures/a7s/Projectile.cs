// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class Projectile {

		[BinaryContent(Name = "ProjectileDesc", NodeType = BinaryContentTypes.Node)]
		public ProjectileDesc ProjectileDesc { get; set; }

		[BinaryContent(Name = "LaunchRotationWS", NodeType = BinaryContentTypes.Attribute)]
		public HexString LaunchRotationWS { get; set; }

		[BinaryContent(Name = "ProjectileState", NodeType = BinaryContentTypes.Attribute)]
		public HexString ProjectileState { get; set; }

		[BinaryContent(Name = "HitTimeout", NodeType = BinaryContentTypes.Attribute)]
		public HexString HitTimeout { get; set; }

		[BinaryContent(Name = "Velocity", NodeType = BinaryContentTypes.Attribute)]
		public HexString Velocity { get; set; }

		[BinaryContent(Name = "LaunchTime", NodeType = BinaryContentTypes.Attribute)]
		public HexString LaunchTime { get; set; }

	}
}
