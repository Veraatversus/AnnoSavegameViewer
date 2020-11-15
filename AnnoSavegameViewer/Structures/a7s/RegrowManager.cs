namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class RegrowManager {

		[BinaryContent(Name = "TreeMap", NodeType = BinaryContentTypes.Node)]
		public TreeMap TreeMap { get; set; }

		[BinaryContent(Name = "CreatedTreeMap", NodeType = BinaryContentTypes.Node)]
		public CreatedTreeMap CreatedTreeMap { get; set; }

		[BinaryContent(Name = "GrowingMap", NodeType = BinaryContentTypes.Node)]
		public GrowingMap GrowingMap { get; set; }

	}
}
