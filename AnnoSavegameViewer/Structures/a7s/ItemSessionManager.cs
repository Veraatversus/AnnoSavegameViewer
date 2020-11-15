namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class ItemSessionManager {

		[BinaryContent(Name = "ItemIdCounter", NodeType = BinaryContentTypes.Attribute)]
		public Int32 ItemIdCounter { get; set; }

		[BinaryContent(Name = "ItemMap", NodeType = BinaryContentTypes.Node)]
		public ItemMap ItemMap { get; set; }

		[BinaryContent(Name = "ProductItem", NodeType = BinaryContentTypes.Node)]
		public ProductItem ProductItem { get; set; }

		[BinaryContent(Name = "BuffFluffIndex", NodeType = BinaryContentTypes.Attribute)]
		public Int64 BuffFluffIndex { get; set; }

		[BinaryContent(Name = "TimeWhenBuffFluffIndexIncrease", NodeType = BinaryContentTypes.Attribute)]
		public Int64 TimeWhenBuffFluffIndexIncrease { get; set; }

		[BinaryContent(Name = "SetBuffs", NodeType = BinaryContentTypes.Node)]
		public SetBuffs SetBuffs { get; set; }

		[BinaryContent(Name = "AdditionalAreaEffects", NodeType = BinaryContentTypes.Node)]
		public AdditionalAreaEffects AdditionalAreaEffects { get; set; }

		[BinaryContent(Name = "AdditionalSessionEffects", NodeType = BinaryContentTypes.Node)]
		public AdditionalSessionEffects AdditionalSessionEffects { get; set; }

		[BinaryContent(Name = "TrackedPaths", NodeType = BinaryContentTypes.Node)]
		public TrackedPaths TrackedPaths { get; set; }

		[BinaryContent(Name = "DynamicRangeSources", NodeType = BinaryContentTypes.Node)]
		public DynamicRangeSources DynamicRangeSources { get; set; }

	}
}
