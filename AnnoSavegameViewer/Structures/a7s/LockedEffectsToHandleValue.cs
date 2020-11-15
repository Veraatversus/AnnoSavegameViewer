namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class LockedEffectsToHandleValue {

		[BinaryContent(Name = "Ministry", NodeType = BinaryContentTypes.Node)]
		public NoneMinistry Ministry { get; set; }

		[BinaryContent(Name = "Decree", NodeType = BinaryContentTypes.Node)]
		public NoneDecree Decree { get; set; }

	}
}
