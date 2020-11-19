// Copyright � 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class RequestHandler {

		[BinaryContent(Name = "AllRequests", NodeType = BinaryContentTypes.Node)]
		public AllRequests AllRequests { get; set; }

		[BinaryContent(Name = "LastTick", NodeType = BinaryContentTypes.Attribute)]
		public HexString LastTick { get; set; }

		[BinaryContent(Name = "LastConsistencyCheck", NodeType = BinaryContentTypes.Attribute)]
		public HexString LastConsistencyCheck { get; set; }

		[BinaryContent(Name = "Balance", NodeType = BinaryContentTypes.Node)]
		public Balance Balance { get; set; }

	}
}
