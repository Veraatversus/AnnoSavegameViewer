namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class BlockedTrainInfosValue {

		[BinaryContent(Name = "EntryKillTime", NodeType = BinaryContentTypes.Attribute)]
		public HexString EntryKillTime { get; set; }

		[BinaryContent(Name = "BlockedGameObjectID", NodeType = BinaryContentTypes.Attribute)]
		public HexString BlockedGameObjectID { get; set; }

		[BinaryContent(Name = "BlockDuration", NodeType = BinaryContentTypes.Attribute)]
		public HexString BlockDuration { get; set; }

	}
}
