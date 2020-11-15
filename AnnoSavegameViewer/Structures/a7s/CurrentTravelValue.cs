namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class CurrentTravelValue {

		[BinaryContent(Name = "Target", NodeType = BinaryContentTypes.Attribute)]
		public HexString Target { get; set; }

		[BinaryContent(Name = "Origin", NodeType = BinaryContentTypes.Attribute)]
		public HexString Origin { get; set; }

	}
}
