// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;
	using System.Collections.Generic;

	public partial class NonePositions : KeysList<Point2D<Int32>> {

		[BinaryContent(Name = "None", NodeType = BinaryContentTypes.Attribute)]
		public override List<Point2D<Int32>> Keys { get; set; }

	}
}
