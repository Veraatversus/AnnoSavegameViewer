namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class TemplateElementElement {

		[BinaryContent(Name = "Position", NodeType = BinaryContentTypes.Attribute)]
		public Point2D<Int32> Position { get; set; }

		[BinaryContent(Name = "MapFilePath", NodeType = BinaryContentTypes.Attribute, Encoding = "utf-16")]
		public String MapFilePath { get; set; }

		[BinaryContent(Name = "Rotation90", NodeType = BinaryContentTypes.Attribute)]
		public HexString Rotation90 { get; set; }

		[BinaryContent(Name = "IslandLabel", NodeType = BinaryContentTypes.Attribute)]
		public HexString IslandLabel { get; set; }

		[BinaryContent(Name = "FertilityGuids", NodeType = BinaryContentTypes.Attribute)]
		public GenericList<DescriptionInt> FertilityGuids { get; set; }

		[BinaryContent(Name = "RandomizeFertilities", NodeType = BinaryContentTypes.Attribute)]
		public Boolean RandomizeFertilities { get; set; }

		[BinaryContent(Name = "MineSlotMapping", NodeType = BinaryContentTypes.Node)]
		public MineSlotMapping MineSlotMapping { get; set; }

		[BinaryContent(Name = "RandomIslandConfig", NodeType = BinaryContentTypes.Node)]
		public RandomIslandConfig RandomIslandConfig { get; set; }

	}
}
