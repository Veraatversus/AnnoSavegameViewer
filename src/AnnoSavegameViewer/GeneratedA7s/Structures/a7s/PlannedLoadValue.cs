// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class PlannedLoadValue {

		[BinaryContent(Name = "UnloadGuid", NodeType = BinaryContentTypes.Attribute)]
		public DescriptionInt UnloadGuid { get; set; }

		[BinaryContent(Name = "UnloadAmount", NodeType = BinaryContentTypes.Attribute)]
		public Int32 UnloadAmount { get; set; }

		[BinaryContent(Name = "ID", NodeType = BinaryContentTypes.Attribute)]
		public Int32 ID { get; set; }

		[BinaryContent(Name = "LoadGuid", NodeType = BinaryContentTypes.Attribute)]
		public DescriptionInt LoadGuid { get; set; }

		[BinaryContent(Name = "LoadAmount", NodeType = BinaryContentTypes.Attribute)]
		public Int32 LoadAmount { get; set; }

	}
}
