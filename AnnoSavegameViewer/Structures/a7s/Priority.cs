namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class Priority {

		[BinaryContent(Name = "Priority", NodeType = BinaryContentTypes.Attribute)]
		public HexString PriorityItem { get; set; }

	}
}
