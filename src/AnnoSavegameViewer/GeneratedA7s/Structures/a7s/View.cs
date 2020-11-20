// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class View {

		[BinaryContent(Name = "From", NodeType = BinaryContentTypes.Attribute)]
		public HexString From { get; set; }

		[BinaryContent(Name = "At", NodeType = BinaryContentTypes.Attribute)]
		public HexString At { get; set; }

		[BinaryContent(Name = "Up", NodeType = BinaryContentTypes.Attribute)]
		public HexString Up { get; set; }

		[BinaryContent(Name = "Direction", NodeType = BinaryContentTypes.Attribute)]
		public HexString Direction { get; set; }

	}
}
