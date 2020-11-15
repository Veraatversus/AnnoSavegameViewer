namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class EventPreparationValue {

		[BinaryContent(Name = "MaxNeededAmount", NodeType = BinaryContentTypes.Attribute)]
		public HexString MaxNeededAmount { get; set; }

	}
}
