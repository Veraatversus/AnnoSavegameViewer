// Copyright � 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class HarbourLayout {

		[BinaryContent(Name = "HarborCount", NodeType = BinaryContentTypes.Attribute)]
		public HexString HarborCount { get; set; }

		[BinaryContent(Name = "ID", NodeType = BinaryContentTypes.Attribute)]
		public HexString ID { get; set; }

		[BinaryContent(Name = "Harbor", NodeType = BinaryContentTypes.Node)]
		public Harbor Harbor { get; set; }

		[BinaryContent(Name = "harborBlockExtension", NodeType = BinaryContentTypes.Attribute)]
		public HexString HarborBlockExtension { get; set; }

	}
}
