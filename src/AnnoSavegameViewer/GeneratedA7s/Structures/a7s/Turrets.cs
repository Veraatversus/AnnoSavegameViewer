// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class Turrets {

		[BinaryContent(Name = "count", NodeType = BinaryContentTypes.Attribute)]
		public HexString Count { get; set; }

		[BinaryContent(Name = "CanFireAtTarget", NodeType = BinaryContentTypes.Attribute)]
		public HexString CanFireAtTarget { get; set; }

		[BinaryContent(Name = "enemyFocusDuration", NodeType = BinaryContentTypes.Attribute)]
		public HexString EnemyFocusDuration { get; set; }

	}
}
