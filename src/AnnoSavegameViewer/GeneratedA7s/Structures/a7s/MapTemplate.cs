// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class MapTemplate {

		[BinaryContent(Name = "Size", NodeType = BinaryContentTypes.Attribute)]
		public Point2D<Int32> Size { get; set; }

		[BinaryContent(Name = "PlayableArea", NodeType = BinaryContentTypes.Attribute)]
		public Point3D<Int32> PlayableArea { get; set; }

		[BinaryContent(Name = "RandomlyPlacedThirdParties", NodeType = BinaryContentTypes.Node)]
		public RandomlyPlacedThirdParties RandomlyPlacedThirdParties { get; set; }

		[BinaryContent(Name = "Filename", NodeType = BinaryContentTypes.Attribute, Encoding = "utf-16")]
		public String Filename { get; set; }

		[BinaryContent(Name = "ElementCount", NodeType = BinaryContentTypes.Attribute)]
		public Int32 ElementCount { get; set; }

		[BinaryContent(Name = "TemplateElement", NodeType = BinaryContentTypes.Node)]
		public TemplateElement TemplateElement { get; set; }

	}
}
