namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class StreetMap {

		[BinaryContent(Name = "StreetID", NodeType = BinaryContentTypes.Node)]
		public StreetID StreetID { get; set; }

		[BinaryContent(Name = "VarMapData", NodeType = BinaryContentTypes.Node)]
		public VarMapData VarMapData { get; set; }

	}
}
