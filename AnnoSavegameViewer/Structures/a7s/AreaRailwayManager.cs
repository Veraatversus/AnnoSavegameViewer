namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class AreaRailwayManager {

		[BinaryContent(Name = "RailwayNodeGraph", NodeType = BinaryContentTypes.Node)]
		public RailwayNodeGraph RailwayNodeGraph { get; set; }

	}
}
