// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class Powerplant {

		[BinaryContent(Name = "ProductionState", NodeType = BinaryContentTypes.Node)]
		public PowerplantProductionState ProductionState { get; set; }

		[BinaryContent(Name = "IsActive", NodeType = BinaryContentTypes.Attribute)]
		public HexString IsActive { get; set; }

	}
}
