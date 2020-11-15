namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class PossibleThirdPartiesValue {

		[BinaryContent(Name = "ProfileGUID", NodeType = BinaryContentTypes.Attribute)]
		public DescriptionInt ProfileGUID { get; set; }

		[BinaryContent(Name = "ActiveRegions", NodeType = BinaryContentTypes.Node)]
		public ActiveRegions ActiveRegions { get; set; }

	}
}
