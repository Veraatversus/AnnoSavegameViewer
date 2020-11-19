// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class CounterProposalActionsValue {

		[BinaryContent(Name = "action", NodeType = BinaryContentTypes.Node)]
		public Action Action { get; set; }

		[BinaryContent(Name = "target", NodeType = BinaryContentTypes.Node)]
		public NoneTarget Target { get; set; }

		[BinaryContent(Name = "source", NodeType = BinaryContentTypes.Node)]
		public ActionsValuesNoneSource Source { get; set; }

		[BinaryContent(Name = "cost", NodeType = BinaryContentTypes.Node)]
		public Cost Cost { get; set; }

		[BinaryContent(Name = "other", NodeType = BinaryContentTypes.Node)]
		public Other Other { get; set; }

		[BinaryContent(Name = "areaID", NodeType = BinaryContentTypes.Attribute)]
		public HexString AreaID { get; set; }

		[BinaryContent(Name = "amount", NodeType = BinaryContentTypes.Attribute)]
		public HexString Amount { get; set; }

	}
}
