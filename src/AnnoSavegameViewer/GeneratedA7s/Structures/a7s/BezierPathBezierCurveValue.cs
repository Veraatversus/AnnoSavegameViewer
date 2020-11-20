// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class BezierPathBezierCurveValue {

		[BinaryContent(Name = "p", NodeType = BinaryContentTypes.Attribute)]
		public HexString P { get; set; }

		[BinaryContent(Name = "i", NodeType = BinaryContentTypes.Attribute)]
		public HexString I { get; set; }

		[BinaryContent(Name = "o", NodeType = BinaryContentTypes.Attribute)]
		public HexString O { get; set; }

	}
}
