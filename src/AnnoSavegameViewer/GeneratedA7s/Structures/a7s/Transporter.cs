// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class Transporter {

		[BinaryContent(Name = "Parent", NodeType = BinaryContentTypes.Node)]
		public TransporterParent Parent { get; set; }

		[BinaryContent(Name = "Type", NodeType = BinaryContentTypes.Attribute)]
		public HexString Type { get; set; }

		[BinaryContent(Name = "Index", NodeType = BinaryContentTypes.Attribute)]
		public HexString Index { get; set; }

	}
}
