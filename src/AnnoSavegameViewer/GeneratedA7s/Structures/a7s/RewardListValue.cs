// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class RewardListValue {

		[BinaryContent(Name = "Amount", NodeType = BinaryContentTypes.Attribute)]
		public Int16 Amount { get; set; }

		[BinaryContent(Name = "AssetGUID", NodeType = BinaryContentTypes.Attribute)]
		public DescriptionInt AssetGUID { get; set; }

		[BinaryContent(Name = "SentToQuestArea", NodeType = BinaryContentTypes.Attribute)]
		public HexString SentToQuestArea { get; set; }

		[BinaryContent(Name = "IsDisguised", NodeType = BinaryContentTypes.Attribute)]
		public HexString IsDisguised { get; set; }

	}
}
