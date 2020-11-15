namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class StorageValue {

		[BinaryContent(Name = "ProductGUID", NodeType = BinaryContentTypes.Attribute)]
		public DescriptionInt ProductGUID { get; set; }

		[BinaryContent(Name = "CurrentAmount", NodeType = BinaryContentTypes.Attribute)]
		public Int32 CurrentAmount { get; set; }

		[BinaryContent(Name = "MaxAmount", NodeType = BinaryContentTypes.Attribute)]
		public Int32 MaxAmount { get; set; }

		[BinaryContent(Name = "ReservedAmount", NodeType = BinaryContentTypes.Node)]
		public ReservedAmount ReservedAmount { get; set; }

		[BinaryContent(Name = "ReservedSpace", NodeType = BinaryContentTypes.Node)]
		public ReservedSpace ReservedSpace { get; set; }

		[BinaryContent(Name = "CanBeNegative", NodeType = BinaryContentTypes.Attribute)]
		public Boolean CanBeNegative { get; set; }

	}
}
