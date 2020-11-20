// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using System;

	public partial class NoneFilterValue {

		[BinaryContent(Name = "FolderID", NodeType = BinaryContentTypes.Attribute)]
		public Int32 FolderID { get; set; }

		[BinaryContent(Name = "Filter", NodeType = BinaryContentTypes.Node)]
		public ValuesNoneFilter Filter { get; set; }

	}
}
