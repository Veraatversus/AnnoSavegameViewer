// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class Preparation {

		[BinaryContent(Name = "kontorID", NodeType = BinaryContentTypes.Attribute)]
		public HexString KontorID { get; set; }

		[BinaryContent(Name = "TradeRequests", NodeType = BinaryContentTypes.Node)]
		public TradeRequests TradeRequests { get; set; }

		[BinaryContent(Name = "ReservedAmount", NodeType = BinaryContentTypes.Node)]
		public PreparationReservedAmount ReservedAmount { get; set; }

	}
}
