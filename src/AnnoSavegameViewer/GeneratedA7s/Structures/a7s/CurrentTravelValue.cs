// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class CurrentTravelValue {

		[BinaryContent(Name = "Target", NodeType = BinaryContentTypes.Attribute)]
		public HexString Target { get; set; }

		[BinaryContent(Name = "Origin", NodeType = BinaryContentTypes.Attribute)]
		public HexString Origin { get; set; }

	}
}
