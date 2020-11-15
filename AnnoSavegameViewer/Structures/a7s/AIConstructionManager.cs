namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class AIConstructionManager {

		[BinaryContent(Name = "PlannedSettlements", NodeType = BinaryContentTypes.Node)]
		public PlannedSettlements PlannedSettlements { get; set; }

	}
}
