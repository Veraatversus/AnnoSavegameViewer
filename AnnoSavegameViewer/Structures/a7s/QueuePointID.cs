namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class QueuePointID {

		[BinaryContent(Name = "InRowIndex", NodeType = BinaryContentTypes.Attribute)]
		public HexString InRowIndex { get; set; }

	}
}
