// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class MilitaryManager {

		[BinaryContent(Name = "nextFightID", NodeType = BinaryContentTypes.Attribute)]
		public HexString NextFightID { get; set; }

		[BinaryContent(Name = "ObjectToFightId", NodeType = BinaryContentTypes.Node)]
		public ObjectToFightId ObjectToFightId { get; set; }

		[BinaryContent(Name = "FightIdToFight", NodeType = BinaryContentTypes.Node)]
		public FightIdToFight FightIdToFight { get; set; }

	}
}
