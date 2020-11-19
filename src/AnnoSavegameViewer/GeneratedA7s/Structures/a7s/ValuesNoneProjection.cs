// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class ValuesNoneProjection {

		[BinaryContent(Name = "Flags", NodeType = BinaryContentTypes.Attribute)]
		public HexString Flags { get; set; }

		[BinaryContent(Name = "FOV", NodeType = BinaryContentTypes.Attribute)]
		public HexString FOV { get; set; }

		[BinaryContent(Name = "NearClip", NodeType = BinaryContentTypes.Attribute)]
		public HexString NearClip { get; set; }

		[BinaryContent(Name = "FarClip", NodeType = BinaryContentTypes.Attribute)]
		public HexString FarClip { get; set; }

		[BinaryContent(Name = "AspectRatio", NodeType = BinaryContentTypes.Attribute)]
		public HexString AspectRatio { get; set; }

	}
}
