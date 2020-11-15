namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class BuildingWithEffectActiveValue {

		[BinaryContent(Name = "Guid", NodeType = BinaryContentTypes.Attribute)]
		public HexString Guid { get; set; }

		[BinaryContent(Name = "Amount", NodeType = BinaryContentTypes.Attribute)]
		public HexString Amount { get; set; }

	}
}
