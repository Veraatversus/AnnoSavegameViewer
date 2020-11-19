// Copyright � 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class StartQuestData {

		[BinaryContent(Name = "QuestLineGUID", NodeType = BinaryContentTypes.Attribute)]
		public DescriptionInt QuestLineGUID { get; set; }

		[BinaryContent(Name = "MetaData", NodeType = BinaryContentTypes.Node)]
		public MetaData MetaData { get; set; }

		[BinaryContent(Name = "TriggeringChain", NodeType = BinaryContentTypes.Attribute)]
		public HexString TriggeringChain { get; set; }

	}
}
