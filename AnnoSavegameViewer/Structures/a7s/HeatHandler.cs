namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class HeatHandler {

		[BinaryContent(Name = "Heaters", NodeType = BinaryContentTypes.Node)]
		public Heaters Heaters { get; set; }

	}
}
