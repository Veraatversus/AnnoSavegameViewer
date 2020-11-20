// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using System;

	public partial class BuildingModule {

		[BinaryContent(Name = "ParentFactoryID", NodeType = BinaryContentTypes.Attribute)]
		public Int64 ParentFactoryID { get; set; }

		[BinaryContent(Name = "CultureSlotIndex", NodeType = BinaryContentTypes.Attribute)]
		public Int32 CultureSlotIndex { get; set; }

	}
}
