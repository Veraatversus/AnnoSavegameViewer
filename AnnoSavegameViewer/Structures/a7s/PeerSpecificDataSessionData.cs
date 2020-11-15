namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;
	using System.Collections.Generic;

	public partial class PeerSpecificDataSessionData : ValuesList<SessionDataValue> {

		[BinaryContent(Name = "size", NodeType = BinaryContentTypes.Attribute)]
		public Int32 Size { get; set; }

		[BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
		public override List<SessionDataValue> Values { get; set; }

	}
}
