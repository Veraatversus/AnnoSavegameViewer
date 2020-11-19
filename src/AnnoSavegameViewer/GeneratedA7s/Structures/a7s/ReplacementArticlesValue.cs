// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class ReplacementArticlesValue {

		[BinaryContent(Name = "ID", NodeType = BinaryContentTypes.Attribute)]
		public HexString ID { get; set; }

		[BinaryContent(Name = "Size", NodeType = BinaryContentTypes.Node)]
		public NoneSize Size { get; set; }

		[BinaryContent(Name = "Context", NodeType = BinaryContentTypes.Node)]
		public ValuesNoneContext Context { get; set; }

		[BinaryContent(Name = "IsUsedForNewspaper", NodeType = BinaryContentTypes.Attribute)]
		public HexString IsUsedForNewspaper { get; set; }

	}
}
