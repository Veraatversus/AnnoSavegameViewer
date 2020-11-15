namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class EconomyStatisticManager {

		[BinaryContent(Name = "History", NodeType = BinaryContentTypes.Node)]
		public History History { get; set; }

	}
}
