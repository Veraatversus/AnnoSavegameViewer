// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class BuildingWithEffectActiveValue {

		[BinaryContent(Name = "Guid", NodeType = BinaryContentTypes.Attribute)]
		public HexString Guid { get; set; }

		[BinaryContent(Name = "Amount", NodeType = BinaryContentTypes.Attribute)]
		public HexString Amount { get; set; }

	}
}
