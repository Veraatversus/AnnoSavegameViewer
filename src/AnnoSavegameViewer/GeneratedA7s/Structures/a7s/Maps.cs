// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class Maps {

		[BinaryContent(Name = "count", NodeType = BinaryContentTypes.Attribute)]
		public Int64 Count { get; set; }

		[BinaryContent(Name = "Asset", NodeType = BinaryContentTypes.Attribute)]
		public DescriptionInt Asset { get; set; }

	}
}
