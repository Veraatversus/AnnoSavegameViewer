namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class PrioType {

		[BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
		public PrioTypeValue Value { get; set; }

	}
}
