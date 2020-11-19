// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using System;

	public partial class GroupsValue {

		[BinaryContent(Name = "ID", NodeType = BinaryContentTypes.Attribute)]
		public Int16 ID { get; set; }

		[BinaryContent(Name = "Units", NodeType = BinaryContentTypes.Attribute)]
		public Int64 Units { get; set; }

	}
}
