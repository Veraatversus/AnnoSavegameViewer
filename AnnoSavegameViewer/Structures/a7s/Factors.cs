namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class Factors {

		[BinaryContent(Name = "base", NodeType = BinaryContentTypes.Attribute)]
		public HexString Base { get; set; }

		[BinaryContent(Name = "density", NodeType = BinaryContentTypes.Attribute)]
		public HexString Density { get; set; }

		[BinaryContent(Name = "productivity", NodeType = BinaryContentTypes.Attribute)]
		public HexString Productivity { get; set; }

		[BinaryContent(Name = "workingCondF", NodeType = BinaryContentTypes.Attribute)]
		public HexString WorkingCondF { get; set; }

		[BinaryContent(Name = "residenceHappiness", NodeType = BinaryContentTypes.Attribute)]
		public HexString ResidenceHappiness { get; set; }

		[BinaryContent(Name = "factoryHappiness", NodeType = BinaryContentTypes.Attribute)]
		public HexString FactoryHappiness { get; set; }

		[BinaryContent(Name = "workingCondR", NodeType = BinaryContentTypes.Attribute)]
		public HexString WorkingCondR { get; set; }

		[BinaryContent(Name = "satisfaction", NodeType = BinaryContentTypes.Attribute)]
		public HexString Satisfaction { get; set; }

		[BinaryContent(Name = "heatChance", NodeType = BinaryContentTypes.Attribute)]
		public HexString HeatChance { get; set; }

	}
}
