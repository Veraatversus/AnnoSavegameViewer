// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class BezierPathPath {

		[BinaryContent(Name = "TangentScale", NodeType = BinaryContentTypes.Attribute)]
		public Single TangentScale { get; set; }

		[BinaryContent(Name = "Minimum", NodeType = BinaryContentTypes.Attribute)]
		public Point3D<Single> Minimum { get; set; }

		[BinaryContent(Name = "Maximum", NodeType = BinaryContentTypes.Attribute)]
		public Point3D<Single> Maximum { get; set; }

		[BinaryContent(Name = "BezierCurve", NodeType = BinaryContentTypes.Node)]
		public PathBezierCurve BezierCurve { get; set; }

	}
}
