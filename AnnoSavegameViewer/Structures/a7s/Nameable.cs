namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class Nameable {

		[BinaryContent(Name = "VehicleName", NodeType = BinaryContentTypes.Attribute, Encoding = "utf-16")]
		public String VehicleName { get; set; }

		[BinaryContent(Name = "VehicleTextGuid", NodeType = BinaryContentTypes.Attribute)]
		public DescriptionInt VehicleTextGuid { get; set; }

		[BinaryContent(Name = "VehicleTextIterator", NodeType = BinaryContentTypes.Attribute)]
		public Int32 VehicleTextIterator { get; set; }

	}
}
