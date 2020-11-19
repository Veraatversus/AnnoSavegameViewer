// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;

	public partial class StreetMap {

		[BinaryContent(Name = "StreetID", NodeType = BinaryContentTypes.Node)]
		public StreetID StreetID { get; set; }

		[BinaryContent(Name = "VarMapData", NodeType = BinaryContentTypes.Node)]
		public VarMapData VarMapData { get; set; }

	}
}
