// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class IconsValue {

		[BinaryContent(Name = "VisibilityMaskNew", NodeType = BinaryContentTypes.Attribute)]
		public HexString VisibilityMaskNew { get; set; }

		[BinaryContent(Name = "GUID", NodeType = BinaryContentTypes.Attribute)]
		public DescriptionInt GUID { get; set; }

		[BinaryContent(Name = "ShowTime", NodeType = BinaryContentTypes.Attribute)]
		public TimeSpan ShowTime { get; set; }

		[BinaryContent(Name = "HadCallback", NodeType = BinaryContentTypes.Attribute)]
		public HexString HadCallback { get; set; }

	}
}
