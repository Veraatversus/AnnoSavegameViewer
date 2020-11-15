namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class ModuleOwner {

		[BinaryContent(Name = "BuildingModules", NodeType = BinaryContentTypes.Attribute)]
		public HexString BuildingModules { get; set; }

		[BinaryContent(Name = "AdditionalModule", NodeType = BinaryContentTypes.Node)]
		public AdditionalModule AdditionalModule { get; set; }

		[BinaryContent(Name = "SlotIndexGenerator", NodeType = BinaryContentTypes.Attribute)]
		public HexString SlotIndexGenerator { get; set; }

	}
}
