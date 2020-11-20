// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class Prop {

		[BinaryContent(Name = "Position", NodeType = BinaryContentTypes.Attribute)]
		public Point3D<Single> Position { get; set; }

		[BinaryContent(Name = "Rotation", NodeType = BinaryContentTypes.Attribute)]
		public Point3D<Single> Rotation { get; set; }

		[BinaryContent(Name = "Scale", NodeType = BinaryContentTypes.Attribute)]
		public Point3D<Single> Scale { get; set; }

		[BinaryContent(Name = "Color", NodeType = BinaryContentTypes.Attribute)]
		public Point3D<Single> Color { get; set; }

	}
}
