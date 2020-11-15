namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class History {

		[BinaryContent(Name = "globalHistory", NodeType = BinaryContentTypes.Node)]
		public GlobalHistory GlobalHistory { get; set; }

		[BinaryContent(Name = "areaHistory", NodeType = BinaryContentTypes.Node)]
		public AreaHistory AreaHistory { get; set; }

		[BinaryContent(Name = "lastSnapshot", NodeType = BinaryContentTypes.Attribute)]
		public HexString LastSnapshot { get; set; }

	}
}
