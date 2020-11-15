namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class ValuesNoneIDManager {

		[BinaryContent(Name = "FreeIDList", NodeType = BinaryContentTypes.Node)]
		public ValuesNoneIDManagerFreeIDList FreeIDList { get; set; }

		[BinaryContent(Name = "NextID", NodeType = BinaryContentTypes.Attribute)]
		public HexString NextID { get; set; }

		[BinaryContent(Name = "HotIDList", NodeType = BinaryContentTypes.Node)]
		public ValuesNoneIDManagerHotIDList HotIDList { get; set; }

	}
}
