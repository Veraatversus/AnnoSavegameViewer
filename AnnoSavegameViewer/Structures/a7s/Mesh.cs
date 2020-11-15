namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class Mesh {

		[BinaryContent(Name = "Flags", NodeType = BinaryContentTypes.Node)]
		public Flags Flags { get; set; }

		[BinaryContent(Name = "DyeColorDetail", NodeType = BinaryContentTypes.Attribute)]
		public HexString DyeColorDetail { get; set; }

		[BinaryContent(Name = "SequenceData", NodeType = BinaryContentTypes.Node)]
		public SequenceData SequenceData { get; set; }

		[BinaryContent(Name = "Orientation", NodeType = BinaryContentTypes.Attribute)]
		public Point3D<Single> Orientation { get; set; }

		[BinaryContent(Name = "Damage", NodeType = BinaryContentTypes.Attribute)]
		public HexString Damage { get; set; }

		[BinaryContent(Name = "Scale", NodeType = BinaryContentTypes.Attribute)]
		public Single Scale { get; set; }

		[BinaryContent(Name = "DyeColor", NodeType = BinaryContentTypes.Attribute)]
		public HexString DyeColor { get; set; }

	}
}
