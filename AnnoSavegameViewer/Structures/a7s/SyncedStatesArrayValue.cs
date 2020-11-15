namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class SyncedStatesArrayValue {

		[BinaryContent(Name = "View", NodeType = BinaryContentTypes.Node)]
		public ValuesNoneView View { get; set; }

		[BinaryContent(Name = "Projection", NodeType = BinaryContentTypes.Node)]
		public ValuesNoneProjection Projection { get; set; }

		[BinaryContent(Name = "PresetId", NodeType = BinaryContentTypes.Attribute)]
		public HexString PresetId { get; set; }

	}
}
