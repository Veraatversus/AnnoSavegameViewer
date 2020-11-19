// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class ActionListFailureValue {

		[BinaryContent(Name = "actionType", NodeType = BinaryContentTypes.Node)]
		public ActionListFailureValuesNoneActionType ActionType { get; set; }

		[BinaryContent(Name = "OwnerParticipant", NodeType = BinaryContentTypes.Node)]
		public ActionListFailureValuesNoneOwnerParticipant OwnerParticipant { get; set; }

		[BinaryContent(Name = "AssetGUID", NodeType = BinaryContentTypes.Attribute)]
		public HexString AssetGUID { get; set; }

		[BinaryContent(Name = "ActionID", NodeType = BinaryContentTypes.Attribute)]
		public HexString ActionID { get; set; }

		[BinaryContent(Name = "TargetPeer", NodeType = BinaryContentTypes.Node)]
		public ActionListFailureValuesNoneTargetPeer TargetPeer { get; set; }

	}
}
