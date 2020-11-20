// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class Reservation {

		[BinaryContent(Name = "Position", NodeType = BinaryContentTypes.Attribute)]
		public Point2D<Single> Position { get; set; }

		[BinaryContent(Name = "RectSize", NodeType = BinaryContentTypes.Attribute)]
		public HexString RectSize { get; set; }

		[BinaryContent(Name = "Direction", NodeType = BinaryContentTypes.Attribute)]
		public Single Direction { get; set; }

	}
}
