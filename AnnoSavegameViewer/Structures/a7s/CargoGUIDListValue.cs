namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class CargoGUIDListValue {

		[BinaryContent(Name = "CargoGUID", NodeType = BinaryContentTypes.Attribute)]
		public HexString CargoGUID { get; set; }

		[BinaryContent(Name = "CargoAmount", NodeType = BinaryContentTypes.Attribute)]
		public HexString CargoAmount { get; set; }

	}
}
