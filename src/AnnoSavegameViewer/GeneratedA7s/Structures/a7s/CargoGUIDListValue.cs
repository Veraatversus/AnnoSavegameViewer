// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class CargoGUIDListValue {

		[BinaryContent(Name = "CargoGUID", NodeType = BinaryContentTypes.Attribute)]
		public HexString CargoGUID { get; set; }

		[BinaryContent(Name = "CargoAmount", NodeType = BinaryContentTypes.Attribute)]
		public HexString CargoAmount { get; set; }

	}
}
