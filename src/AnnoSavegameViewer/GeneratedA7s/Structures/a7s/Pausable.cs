// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class Pausable {

		[BinaryContent(Name = "PausedReasons", NodeType = BinaryContentTypes.Attribute)]
		public HexString PausedReasons { get; set; }

	}
}
