namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class MetaProfileCounter {

		[BinaryContent(Name = "Stats", NodeType = BinaryContentTypes.Node)]
		public Stats Stats { get; set; }

	}
}
