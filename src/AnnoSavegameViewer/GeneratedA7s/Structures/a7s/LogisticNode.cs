// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class LogisticNode {

		[BinaryContent(Name = "Storage", NodeType = BinaryContentTypes.Node)]
		public LogisticNodeStorage Storage { get; set; }

		[BinaryContent(Name = "Transporters", NodeType = BinaryContentTypes.Node)]
		public LogisticNodeTransporters Transporters { get; set; }

		[BinaryContent(Name = "TransporterQueue", NodeType = BinaryContentTypes.Node)]
		public TransporterQueue TransporterQueue { get; set; }

		[BinaryContent(Name = "HasBlockedTrain", NodeType = BinaryContentTypes.Attribute)]
		public HexString HasBlockedTrain { get; set; }

	}
}
