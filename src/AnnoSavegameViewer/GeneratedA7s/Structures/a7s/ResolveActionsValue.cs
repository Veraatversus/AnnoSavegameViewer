// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class ResolveActionsValue {

		[BinaryContent(Name = "resolveStartTime", NodeType = BinaryContentTypes.Attribute)]
		public HexString ResolveStartTime { get; set; }

		[BinaryContent(Name = "actionStartedTime", NodeType = BinaryContentTypes.Attribute)]
		public HexString ActionStartedTime { get; set; }

		[BinaryContent(Name = "fightedBuilding", NodeType = BinaryContentTypes.Node)]
		public FightedBuilding FightedBuilding { get; set; }

		[BinaryContent(Name = "resolverID", NodeType = BinaryContentTypes.Node)]
		public ResolverID ResolverID { get; set; }

		[BinaryContent(Name = "speed", NodeType = BinaryContentTypes.Attribute)]
		public HexString Speed { get; set; }

		[BinaryContent(Name = "feedbackClassID", NodeType = BinaryContentTypes.Attribute)]
		public HexString FeedbackClassID { get; set; }

		[BinaryContent(Name = "targetPos", NodeType = BinaryContentTypes.Attribute)]
		public HexString TargetPos { get; set; }

		[BinaryContent(Name = "startParkingLot", NodeType = BinaryContentTypes.Attribute)]
		public HexString StartParkingLot { get; set; }

	}
}
