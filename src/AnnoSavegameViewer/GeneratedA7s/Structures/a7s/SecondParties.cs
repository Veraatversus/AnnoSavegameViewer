// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class SecondParties {

		[BinaryContent(Name = "count", NodeType = BinaryContentTypes.Attribute)]
		public HexString Count { get; set; }

		[BinaryContent(Name = "Participant", NodeType = BinaryContentTypes.Node)]
		public Participant Participant { get; set; }

	}
}
