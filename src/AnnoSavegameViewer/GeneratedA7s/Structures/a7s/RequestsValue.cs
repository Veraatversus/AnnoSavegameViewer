// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class RequestsValue {

		[BinaryContent(Name = "ID", NodeType = BinaryContentTypes.Attribute)]
		public HexString ID { get; set; }

		[BinaryContent(Name = "TargetSession", NodeType = BinaryContentTypes.Attribute)]
		public HexString TargetSession { get; set; }

		[BinaryContent(Name = "TargetPurpose", NodeType = BinaryContentTypes.Node)]
		public TargetPurpose TargetPurpose { get; set; }

		[BinaryContent(Name = "ProductionGUID", NodeType = BinaryContentTypes.Attribute)]
		public HexString ProductionGUID { get; set; }

		[BinaryContent(Name = "Ship", NodeType = BinaryContentTypes.Attribute)]
		public HexString Ship { get; set; }

		[BinaryContent(Name = "RequestGUID", NodeType = BinaryContentTypes.Attribute)]
		public HexString RequestGUID { get; set; }

		[BinaryContent(Name = "ProducedInSession", NodeType = BinaryContentTypes.Attribute)]
		public HexString ProducedInSession { get; set; }

		[BinaryContent(Name = "ProducedByBuilding", NodeType = BinaryContentTypes.Attribute)]
		public HexString ProducedByBuilding { get; set; }

		[BinaryContent(Name = "ShipRequirements", NodeType = BinaryContentTypes.Node)]
		public ShipRequirements ShipRequirements { get; set; }

		[BinaryContent(Name = "Priority", NodeType = BinaryContentTypes.Node)]
		public Priority Priority { get; set; }

		[BinaryContent(Name = "Source", NodeType = BinaryContentTypes.Node)]
		public ValuesNoneSource Source { get; set; }

		[BinaryContent(Name = "State", NodeType = BinaryContentTypes.Node)]
		public ValuesNoneState State { get; set; }

	}
}
