// Copyright � 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;

	public partial class MetaInfluence {

		[BinaryContent(Name = "UsedAmount", NodeType = BinaryContentTypes.Node)]
		public UsedAmount UsedAmount { get; set; }

		[BinaryContent(Name = "SpentInfluence", NodeType = BinaryContentTypes.Node)]
		public SpentInfluence SpentInfluence { get; set; }

		[BinaryContent(Name = "OldSpentInfluence", NodeType = BinaryContentTypes.Node)]
		public OldSpentInfluence OldSpentInfluence { get; set; }

		[BinaryContent(Name = "InfluenceBuffs", NodeType = BinaryContentTypes.Node)]
		public InfluenceBuffs InfluenceBuffs { get; set; }

	}
}
