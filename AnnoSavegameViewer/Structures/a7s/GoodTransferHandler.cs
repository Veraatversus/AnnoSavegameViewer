namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class GoodTransferHandler {

		[BinaryContent(Name = "activeTransfers", NodeType = BinaryContentTypes.Node)]
		public ActiveTransfers ActiveTransfers { get; set; }

	}
}
