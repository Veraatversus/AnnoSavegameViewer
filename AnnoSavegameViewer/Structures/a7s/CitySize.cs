namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class CitySize {

		[BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
		public CitySizeValue Value { get; set; }

	}
}
