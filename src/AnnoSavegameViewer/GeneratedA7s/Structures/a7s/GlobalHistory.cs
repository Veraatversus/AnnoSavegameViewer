// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;

	public partial class GlobalHistory {

		[BinaryContent(Name = "Snapshots", NodeType = BinaryContentTypes.Node)]
		public Snapshots Snapshots { get; set; }

	}
}
