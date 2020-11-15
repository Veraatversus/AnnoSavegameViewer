namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class DrivewaysValuesNoneValue {

		[BinaryContent(Name = "Driveway", NodeType = BinaryContentTypes.Attribute)]
		public HexString Driveway { get; set; }

		[BinaryContent(Name = "Rotation", NodeType = BinaryContentTypes.Attribute)]
		public HexString Rotation { get; set; }

	}
}
