namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class Element {

		[BinaryContent(Name = "Data", NodeType = BinaryContentTypes.Attribute)]
		public HexString Data { get; set; }

		[BinaryContent(Name = "ID", NodeType = BinaryContentTypes.Attribute)]
		public HexString ID { get; set; }

		[BinaryContent(Name = "Time", NodeType = BinaryContentTypes.Attribute)]
		public HexString Time { get; set; }

		[BinaryContent(Name = "Delta", NodeType = BinaryContentTypes.Attribute)]
		public HexString Delta { get; set; }

	}
}
