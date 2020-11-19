// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;

	public partial class UniqueNamingManager {

		[BinaryContent(Name = "ShipNameList", NodeType = BinaryContentTypes.Node)]
		public ShipNameList ShipNameList { get; set; }

		[BinaryContent(Name = "ShipNameUsed", NodeType = BinaryContentTypes.Node)]
		public ShipNameUsed ShipNameUsed { get; set; }

		[BinaryContent(Name = "NextShipNameIndex", NodeType = BinaryContentTypes.Node)]
		public NextShipNameIndex NextShipNameIndex { get; set; }

		[BinaryContent(Name = "ParticipantSpecificNames", NodeType = BinaryContentTypes.Node)]
		public ParticipantSpecificNames ParticipantSpecificNames { get; set; }

		[BinaryContent(Name = "ParticipantSpecificNamesUsed", NodeType = BinaryContentTypes.Node)]
		public ParticipantSpecificNamesUsed ParticipantSpecificNamesUsed { get; set; }

	}
}
