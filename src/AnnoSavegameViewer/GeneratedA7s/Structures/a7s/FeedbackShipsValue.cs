// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class FeedbackShipsValue {

		[BinaryContent(Name = "TargetArea", NodeType = BinaryContentTypes.Attribute)]
		public Int16 TargetArea { get; set; }

		[BinaryContent(Name = "Target", NodeType = BinaryContentTypes.Node)]
		public ValuesNoneTarget Target { get; set; }

		[BinaryContent(Name = "Ship", NodeType = BinaryContentTypes.Node)]
		public Ship Ship { get; set; }

		[BinaryContent(Name = "ContinueTimestamp", NodeType = BinaryContentTypes.Attribute)]
		public HexString ContinueTimestamp { get; set; }

		[BinaryContent(Name = "Reverse", NodeType = BinaryContentTypes.Attribute)]
		public Boolean Reverse { get; set; }

		[BinaryContent(Name = "State", NodeType = BinaryContentTypes.Node)]
		public FeedbackShipsValuesNoneState State { get; set; }

	}
}
