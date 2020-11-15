namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class TimeEventHeapData {

		[BinaryContent(Name = "prio", NodeType = BinaryContentTypes.Attribute)]
		public HexString Prio { get; set; }

		[BinaryContent(Name = "element", NodeType = BinaryContentTypes.Node)]
		public Element Element { get; set; }

	}
}
