namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class OfferMapValue {

		[BinaryContent(Name = "AreaID", NodeType = BinaryContentTypes.Attribute)]
		public HexString AreaID { get; set; }

		[BinaryContent(Name = "Type", NodeType = BinaryContentTypes.Node)]
		public OfferMapValuesNoneType Type { get; set; }

		[BinaryContent(Name = "TargetAmount", NodeType = BinaryContentTypes.Attribute)]
		public HexString TargetAmount { get; set; }

		[BinaryContent(Name = "GoodGuid", NodeType = BinaryContentTypes.Attribute)]
		public HexString GoodGuid { get; set; }

		[BinaryContent(Name = "IsDirty", NodeType = BinaryContentTypes.Attribute)]
		public HexString IsDirty { get; set; }

		[BinaryContent(Name = "IsPreferedGood", NodeType = BinaryContentTypes.Attribute)]
		public HexString IsPreferedGood { get; set; }

	}
}
