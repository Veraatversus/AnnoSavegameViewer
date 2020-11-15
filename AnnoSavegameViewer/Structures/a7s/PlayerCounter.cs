namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class PlayerCounter {

		[BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
		public PlayerCounterValue Value { get; set; }

	}
}
