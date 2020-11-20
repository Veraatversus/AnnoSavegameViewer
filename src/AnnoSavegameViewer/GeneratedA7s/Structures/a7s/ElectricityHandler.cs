// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class ElectricityHandler {

		[BinaryContent(Name = "PowerPlants", NodeType = BinaryContentTypes.Node)]
		public PowerPlants PowerPlants { get; set; }

		[BinaryContent(Name = "LastRequesterTime", NodeType = BinaryContentTypes.Attribute)]
		public HexString LastRequesterTime { get; set; }

		[BinaryContent(Name = "LastRequester", NodeType = BinaryContentTypes.Node)]
		public LastRequester LastRequester { get; set; }

	}
}
