namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class AreaTriggeredValue {

		[BinaryContent(Name = "Area", NodeType = BinaryContentTypes.Attribute)]
		public HexString Area { get; set; }

		[BinaryContent(Name = "GUID", NodeType = BinaryContentTypes.Attribute)]
		public HexString GUID { get; set; }

	}
}
