namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class ConstructionBarSettingsValue {

		[BinaryContent(Name = "PinConfigLeft", NodeType = BinaryContentTypes.Node)]
		public PinConfigLeft PinConfigLeft { get; set; }

		[BinaryContent(Name = "PinConfigRight", NodeType = BinaryContentTypes.Node)]
		public PinConfigRight PinConfigRight { get; set; }

	}
}
