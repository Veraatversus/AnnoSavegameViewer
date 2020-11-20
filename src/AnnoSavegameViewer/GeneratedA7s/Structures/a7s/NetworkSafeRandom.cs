// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class NetworkSafeRandom {

		[BinaryContent(Name = "P1", NodeType = BinaryContentTypes.Attribute)]
		public HexString P1 { get; set; }

		[BinaryContent(Name = "P2", NodeType = BinaryContentTypes.Attribute)]
		public HexString P2 { get; set; }

		[BinaryContent(Name = "Buffer", NodeType = BinaryContentTypes.Attribute)]
		public HexString Buffer { get; set; }

		[BinaryContent(Name = "Counter", NodeType = BinaryContentTypes.Attribute)]
		public HexString Counter { get; set; }

	}
}
