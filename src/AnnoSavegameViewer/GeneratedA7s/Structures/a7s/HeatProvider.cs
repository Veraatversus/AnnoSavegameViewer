// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class HeatProvider {

		[BinaryContent(Name = "ProductionState", NodeType = BinaryContentTypes.Node)]
		public HeatProviderProductionState ProductionState { get; set; }

		[BinaryContent(Name = "TransporterRange", NodeType = BinaryContentTypes.Attribute)]
		public HexString TransporterRange { get; set; }

	}
}
