// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class Residence7 {

		[BinaryContent(Name = "ResidentCount", NodeType = BinaryContentTypes.Attribute)]
		public Int32 ResidentCount { get; set; }

		[BinaryContent(Name = "ResidenceState", NodeType = BinaryContentTypes.Node)]
		public ResidenceState ResidenceState { get; set; }

		[BinaryContent(Name = "TimeBeforeRuinLeft", NodeType = BinaryContentTypes.Attribute)]
		public Int32 TimeBeforeRuinLeft { get; set; }

		[BinaryContent(Name = "PopulationMoveTimeout", NodeType = BinaryContentTypes.Attribute)]
		public HexString PopulationMoveTimeout { get; set; }

		[BinaryContent(Name = "ProductMoneyOutput", NodeType = BinaryContentTypes.Attribute)]
		public Int32 ProductMoneyOutput { get; set; }

		[BinaryContent(Name = "AverageNeedSaturation", NodeType = BinaryContentTypes.Attribute)]
		public Int32 AverageNeedSaturation { get; set; }

		[BinaryContent(Name = "ConsumptionStates", NodeType = BinaryContentTypes.Node)]
		public ConsumptionStates ConsumptionStates { get; set; }

		[BinaryContent(Name = "NewspaperMoneyOutput", NodeType = BinaryContentTypes.Attribute)]
		public Int32 NewspaperMoneyOutput { get; set; }

		[BinaryContent(Name = "LogisticDirty", NodeType = BinaryContentTypes.Attribute)]
		public HexString LogisticDirty { get; set; }

	}
}
