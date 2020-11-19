// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class SpawnEntriesValue {

		[BinaryContent(Name = "GUID", NodeType = BinaryContentTypes.Attribute)]
		public HexString GUID { get; set; }

		[BinaryContent(Name = "Amount", NodeType = BinaryContentTypes.Attribute)]
		public HexString Amount { get; set; }

		[BinaryContent(Name = "CargoGUIDList", NodeType = BinaryContentTypes.Node)]
		public NoneCargoGUIDList CargoGUIDList { get; set; }

		[BinaryContent(Name = "Owner", NodeType = BinaryContentTypes.Node)]
		public SpawnEntriesValuesNoneOwner Owner { get; set; }

		[BinaryContent(Name = "VisualOwner", NodeType = BinaryContentTypes.Node)]
		public NoneVisualOwner VisualOwner { get; set; }

	}
}
