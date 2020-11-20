// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class BlockedTrainInfosValue {

		[BinaryContent(Name = "EntryKillTime", NodeType = BinaryContentTypes.Attribute)]
		public HexString EntryKillTime { get; set; }

		[BinaryContent(Name = "BlockedGameObjectID", NodeType = BinaryContentTypes.Attribute)]
		public HexString BlockedGameObjectID { get; set; }

		[BinaryContent(Name = "BlockDuration", NodeType = BinaryContentTypes.Attribute)]
		public HexString BlockDuration { get; set; }

	}
}
