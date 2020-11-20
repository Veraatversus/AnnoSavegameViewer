// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class ArticleEffectsValue {

		[BinaryContent(Name = "Effect", NodeType = BinaryContentTypes.Node)]
		public Effect Effect { get; set; }

		[BinaryContent(Name = "Value", NodeType = BinaryContentTypes.Attribute)]
		public HexString Value { get; set; }

		[BinaryContent(Name = "TriggeredByPropaganda", NodeType = BinaryContentTypes.Attribute)]
		public HexString TriggeredByPropaganda { get; set; }

		[BinaryContent(Name = "Context", NodeType = BinaryContentTypes.Attribute)]
		public HexString Context { get; set; }

	}
}
