namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class AvailableCompanyColor {

		[BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
		public AvailableCompanyColorValue Value { get; set; }

	}
}
