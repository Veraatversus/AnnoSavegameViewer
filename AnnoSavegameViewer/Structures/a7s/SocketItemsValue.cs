namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class SocketItemsValue {

		[BinaryContent(Name = "GUID", NodeType = BinaryContentTypes.Attribute)]
		public DescriptionInt GUID { get; set; }

		[BinaryContent(Name = "ActivationTime", NodeType = BinaryContentTypes.Attribute)]
		public TimeSpan ActivationTime { get; set; }

		[BinaryContent(Name = "ItemReference", NodeType = BinaryContentTypes.Node)]
		public ItemReference ItemReference { get; set; }

	}
}
