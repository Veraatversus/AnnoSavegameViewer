// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class AreaVisitorDataValue {

		[BinaryContent(Name = "AreaID", NodeType = BinaryContentTypes.Attribute)]
		public HexString AreaID { get; set; }

		[BinaryContent(Name = "OptimalVisitors", NodeType = BinaryContentTypes.Attribute)]
		public HexString OptimalVisitors { get; set; }

		[BinaryContent(Name = "VisitorIncome", NodeType = BinaryContentTypes.Attribute)]
		public HexString VisitorIncome { get; set; }

		[BinaryContent(Name = "Tier", NodeType = BinaryContentTypes.Attribute)]
		public HexString Tier { get; set; }

		[BinaryContent(Name = "VisitorHarbor", NodeType = BinaryContentTypes.Attribute)]
		public HexString VisitorHarbor { get; set; }

		[BinaryContent(Name = "CurrentVisitors", NodeType = BinaryContentTypes.Attribute)]
		public HexString CurrentVisitors { get; set; }

		[BinaryContent(Name = "EstimatedShipArrival", NodeType = BinaryContentTypes.Attribute)]
		public HexString EstimatedShipArrival { get; set; }

		[BinaryContent(Name = "FirstShipArrived", NodeType = BinaryContentTypes.Attribute)]
		public HexString FirstShipArrived { get; set; }

		[BinaryContent(Name = "Specialist", NodeType = BinaryContentTypes.Node)]
		public Specialist Specialist { get; set; }

		[BinaryContent(Name = "LastMaxVisitorUpdate", NodeType = BinaryContentTypes.Attribute)]
		public HexString LastMaxVisitorUpdate { get; set; }

		[BinaryContent(Name = "VisitorHarberDestructionT", NodeType = BinaryContentTypes.Attribute)]
		public HexString VisitorHarberDestructionT { get; set; }

		[BinaryContent(Name = "SpecialistNot", NodeType = BinaryContentTypes.Attribute)]
		public HexString SpecialistNot { get; set; }

		[BinaryContent(Name = "PrognoseTriggered", NodeType = BinaryContentTypes.Attribute)]
		public HexString PrognoseTriggered { get; set; }

	}
}
