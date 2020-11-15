namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class InteractionsValue {

		[BinaryContent(Name = "AutoClose", NodeType = BinaryContentTypes.Attribute)]
		public HexString AutoClose { get; set; }

		[BinaryContent(Name = "IconGUID", NodeType = BinaryContentTypes.Attribute)]
		public HexString IconGUID { get; set; }

		[BinaryContent(Name = "Callback", NodeType = BinaryContentTypes.Attribute)]
		public HexString Callback { get; set; }

	}
}
