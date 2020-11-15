namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class UnlockData {

		[BinaryContent(Name = "Data", NodeType = BinaryContentTypes.Node)]
		public UnlockDataData Data { get; set; }

	}
}
