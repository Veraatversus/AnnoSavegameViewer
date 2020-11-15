namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class RailwayHandler {

		[BinaryContent(Name = "RailwayBuildings", NodeType = BinaryContentTypes.Node)]
		public RailwayBuildings RailwayBuildings { get; set; }

	}
}
