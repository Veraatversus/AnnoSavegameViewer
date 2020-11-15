namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class SlotContainerSlotListValue {

		[BinaryContent(Name = "Stack", NodeType = BinaryContentTypes.Node)]
		public NoneStack Stack { get; set; }

		[BinaryContent(Name = "ProductStackSize", NodeType = BinaryContentTypes.Attribute)]
		public Int32 ProductStackSize { get; set; }

	}
}
