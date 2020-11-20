// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class ModuleOwner {

		[BinaryContent(Name = "BuildingModules", NodeType = BinaryContentTypes.Attribute)]
		public HexString BuildingModules { get; set; }

		[BinaryContent(Name = "AdditionalModule", NodeType = BinaryContentTypes.Node)]
		public AdditionalModule AdditionalModule { get; set; }

		[BinaryContent(Name = "SlotIndexGenerator", NodeType = BinaryContentTypes.Attribute)]
		public HexString SlotIndexGenerator { get; set; }

	}
}
