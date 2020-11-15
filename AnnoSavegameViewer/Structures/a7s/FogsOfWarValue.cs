namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class FogsOfWarValue {

		[BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
		public FogsOfWarValuesNoneValue Value { get; set; }

		[BinaryContent(Name = "DirtyPositions", NodeType = BinaryContentTypes.Node)]
		public DirtyPositions DirtyPositions { get; set; }

		[BinaryContent(Name = "LastReHideTime", NodeType = BinaryContentTypes.Attribute)]
		public HexString LastReHideTime { get; set; }

	}
}
