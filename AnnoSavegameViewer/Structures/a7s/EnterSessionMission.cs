namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class EnterSessionMission {

		[BinaryContent(Name = "PendingMission", NodeType = BinaryContentTypes.Attribute)]
		public HexString PendingMission { get; set; }

	}
}
