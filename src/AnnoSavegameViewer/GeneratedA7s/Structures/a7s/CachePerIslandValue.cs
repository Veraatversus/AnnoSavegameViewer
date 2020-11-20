// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class CachePerIslandValue {

		[BinaryContent(Name = "Ownage", NodeType = BinaryContentTypes.Attribute)]
		public HexString Ownage { get; set; }

		[BinaryContent(Name = "PreviousRejects", NodeType = BinaryContentTypes.Node)]
		public PreviousRejects PreviousRejects { get; set; }

		[BinaryContent(Name = "CoastErros", NodeType = BinaryContentTypes.Node)]
		public CoastErros CoastErros { get; set; }

		[BinaryContent(Name = "Error", NodeType = BinaryContentTypes.Attribute)]
		public HexString Error { get; set; }

	}
}
