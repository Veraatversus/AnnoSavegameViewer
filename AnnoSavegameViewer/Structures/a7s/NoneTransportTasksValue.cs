namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class NoneTransportTasksValue {

		[BinaryContent(Name = "From", NodeType = BinaryContentTypes.Attribute)]
		public HexString From { get; set; }

		[BinaryContent(Name = "To", NodeType = BinaryContentTypes.Attribute)]
		public HexString To { get; set; }

		[BinaryContent(Name = "Product", NodeType = BinaryContentTypes.Attribute)]
		public HexString Product { get; set; }

		[BinaryContent(Name = "Balance", NodeType = BinaryContentTypes.Attribute)]
		public HexString Balance { get; set; }

		[BinaryContent(Name = "TransportType", NodeType = BinaryContentTypes.Node)]
		public ValuesNoneTransportType TransportType { get; set; }

	}
}
