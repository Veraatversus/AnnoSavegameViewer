// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class AIUnitManager {

		[BinaryContent(Name = "Squads", NodeType = BinaryContentTypes.Node)]
		public Squads Squads { get; set; }

		[BinaryContent(Name = "unitsToSquadIDs", NodeType = BinaryContentTypes.Node)]
		public UnitsToSquadIDs UnitsToSquadIDs { get; set; }

		[BinaryContent(Name = "NextSquadID", NodeType = BinaryContentTypes.Attribute)]
		public HexString NextSquadID { get; set; }

	}
}
