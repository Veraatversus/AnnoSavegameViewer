// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class MinimapManager {

		[BinaryContent(Name = "CityDataSize", NodeType = BinaryContentTypes.Attribute)]
		public Int32 CityDataSize { get; set; }

		[BinaryContent(Name = "CityData", NodeType = BinaryContentTypes.Attribute)]
		public HexString CityData { get; set; }

	}
}
