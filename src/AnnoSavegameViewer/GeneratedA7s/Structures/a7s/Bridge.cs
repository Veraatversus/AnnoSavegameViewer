// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;

	public partial class Bridge {

		[BinaryContent(Name = "Path", NodeType = BinaryContentTypes.Node)]
		public Path Path { get; set; }

		[BinaryContent(Name = "BezierPath", NodeType = BinaryContentTypes.Node)]
		public BridgeBezierPath BezierPath { get; set; }

	}
}
