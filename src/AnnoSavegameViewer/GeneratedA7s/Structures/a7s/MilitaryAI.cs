// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class MilitaryAI {

		[BinaryContent(Name = "TimeUntilUpdate", NodeType = BinaryContentTypes.Attribute)]
		public HexString TimeUntilUpdate { get; set; }

		[BinaryContent(Name = "CurrentStrengthLevel", NodeType = BinaryContentTypes.Node)]
		public CurrentStrengthLevel CurrentStrengthLevel { get; set; }

		[BinaryContent(Name = "TimeUntilAttack", NodeType = BinaryContentTypes.Attribute)]
		public HexString TimeUntilAttack { get; set; }

		[BinaryContent(Name = "TimeUntilBuild", NodeType = BinaryContentTypes.Attribute)]
		public HexString TimeUntilBuild { get; set; }

		[BinaryContent(Name = "TimeUntilDefense", NodeType = BinaryContentTypes.Attribute)]
		public HexString TimeUntilDefense { get; set; }

		[BinaryContent(Name = "TimeUntilEscort", NodeType = BinaryContentTypes.Attribute)]
		public HexString TimeUntilEscort { get; set; }

		[BinaryContent(Name = "TimeUntilPatrol", NodeType = BinaryContentTypes.Attribute)]
		public HexString TimeUntilPatrol { get; set; }

		[BinaryContent(Name = "TimeUntilRepairCheck", NodeType = BinaryContentTypes.Attribute)]
		public HexString TimeUntilRepairCheck { get; set; }

		[BinaryContent(Name = "TimeUntilSquadLogicCheck", NodeType = BinaryContentTypes.Attribute)]
		public HexString TimeUntilSquadLogicCheck { get; set; }

		[BinaryContent(Name = "IsThreatened", NodeType = BinaryContentTypes.Attribute)]
		public HexString IsThreatened { get; set; }

		[BinaryContent(Name = "DangerTrackedParticipant", NodeType = BinaryContentTypes.Node)]
		public DangerTrackedParticipant DangerTrackedParticipant { get; set; }

		[BinaryContent(Name = "MaxFleetSize", NodeType = BinaryContentTypes.Attribute)]
		public HexString MaxFleetSize { get; set; }

		[BinaryContent(Name = "MilitaryShipLimit", NodeType = BinaryContentTypes.Attribute)]
		public HexString MilitaryShipLimit { get; set; }

		[BinaryContent(Name = "HasWar", NodeType = BinaryContentTypes.Attribute)]
		public HexString HasWar { get; set; }

	}
}
