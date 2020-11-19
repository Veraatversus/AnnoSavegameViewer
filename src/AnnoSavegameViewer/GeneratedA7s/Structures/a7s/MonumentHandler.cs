// Copyright � 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class MonumentHandler {

		[BinaryContent(Name = "CurrentConstruction", NodeType = BinaryContentTypes.Attribute)]
		public HexString CurrentConstruction { get; set; }

		[BinaryContent(Name = "Timestamp", NodeType = BinaryContentTypes.Attribute)]
		public HexString Timestamp { get; set; }

		[BinaryContent(Name = "SavedResources", NodeType = BinaryContentTypes.Node)]
		public SavedResources SavedResources { get; set; }

	}
}
