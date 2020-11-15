namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class Collector {

		[BinaryContent(Name = "Collected", NodeType = BinaryContentTypes.Node)]
		public Collected Collected { get; set; }

	}
}
