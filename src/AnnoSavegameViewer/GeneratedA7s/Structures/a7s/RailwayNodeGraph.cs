// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;

	public partial class RailwayNodeGraph {

		[BinaryContent(Name = "Nodes", NodeType = BinaryContentTypes.Node)]
		public Nodes Nodes { get; set; }

		[BinaryContent(Name = "HorizontalEdges", NodeType = BinaryContentTypes.Node)]
		public HorizontalEdges HorizontalEdges { get; set; }

		[BinaryContent(Name = "VerticalEdges", NodeType = BinaryContentTypes.Node)]
		public VerticalEdges VerticalEdges { get; set; }

	}
}
