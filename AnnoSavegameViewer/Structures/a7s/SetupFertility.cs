namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class SetupFertility {

		[BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
		public SetupFertilityValue Value { get; set; }

	}
}
