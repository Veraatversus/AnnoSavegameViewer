// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;

	public partial class AreaTransporterManager {

		[BinaryContent(Name = "Transporters", NodeType = BinaryContentTypes.Node)]
		public AreaTransporterManagerTransporters Transporters { get; set; }

		[BinaryContent(Name = "UnsentTransporters", NodeType = BinaryContentTypes.Node)]
		public UnsentTransporters UnsentTransporters { get; set; }

	}
}
