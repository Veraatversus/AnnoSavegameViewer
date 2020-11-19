// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class Path {

		[BinaryContent(Name = "Minimum", NodeType = BinaryContentTypes.Attribute)]
		public HexString Minimum { get; set; }

		[BinaryContent(Name = "Maximum", NodeType = BinaryContentTypes.Attribute)]
		public HexString Maximum { get; set; }

		[BinaryContent(Name = "BezierCurve", NodeType = BinaryContentTypes.Node)]
		public BezierCurve BezierCurve { get; set; }

	}
}
