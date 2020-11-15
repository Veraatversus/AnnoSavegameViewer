namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class ValuesHuman {

		[BinaryContent(Name = "CompanyName", NodeType = BinaryContentTypes.Attribute)]
		public HexString CompanyName { get; set; }

		[BinaryContent(Name = "AccountId", NodeType = BinaryContentTypes.Attribute)]
		public HexString AccountId { get; set; }

		[BinaryContent(Name = "CompanyPortraitGuid", NodeType = BinaryContentTypes.Attribute)]
		public HexString CompanyPortraitGuid { get; set; }

		[BinaryContent(Name = "CompanyLogoGuid", NodeType = BinaryContentTypes.Attribute)]
		public HexString CompanyLogoGuid { get; set; }

		[BinaryContent(Name = "AccountUnlocks", NodeType = BinaryContentTypes.Node)]
		public HumanAccountUnlocks AccountUnlocks { get; set; }

	}
}
