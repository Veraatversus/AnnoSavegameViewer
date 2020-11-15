namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class CommandGroupInformation {

		[BinaryContent(Name = "OverwriteSetitng", NodeType = BinaryContentTypes.Node)]
		public OverwriteSetitng OverwriteSetitng { get; set; }

		[BinaryContent(Name = "GroupInformation", NodeType = BinaryContentTypes.Node)]
		public GroupInformation GroupInformation { get; set; }

	}
}
