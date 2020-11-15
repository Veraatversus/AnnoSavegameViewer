namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class PeerDataValue {

		[BinaryContent(Name = "CompanyLevel", NodeType = BinaryContentTypes.Attribute)]
		public Int32 CompanyLevel { get; set; }

		[BinaryContent(Name = "PeerSettings", NodeType = BinaryContentTypes.Node)]
		public PeerSettings PeerSettings { get; set; }

	}
}
