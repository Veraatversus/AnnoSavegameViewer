namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class RequirementsValue {

		[BinaryContent(Name = "Region", NodeType = BinaryContentTypes.Node)]
		public NoneRegion Region { get; set; }

		[BinaryContent(Name = "CivLevel", NodeType = BinaryContentTypes.Node)]
		public CivLevel CivLevel { get; set; }

		[BinaryContent(Name = "Amount", NodeType = BinaryContentTypes.Attribute)]
		public HexString Amount { get; set; }

	}
}
