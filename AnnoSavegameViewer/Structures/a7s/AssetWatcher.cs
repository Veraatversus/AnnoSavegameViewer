namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class AssetWatcher {

		[BinaryContent(Name = "AssetListVector", NodeType = BinaryContentTypes.Attribute)]
		public HexString AssetListVector { get; set; }

	}
}
