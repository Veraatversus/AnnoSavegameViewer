namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;
	using System.Collections.Generic;

	public partial class PeerData : ValuesList<PeerDataValue> {

		[BinaryContent(Name = "size", NodeType = BinaryContentTypes.Attribute)]
		public Int32 Size { get; set; }

		[BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
		public override List<PeerDataValue> Values { get; set; }

	}
}
