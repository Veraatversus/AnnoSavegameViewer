// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class ItemContainer {

		[BinaryContent(Name = "SlotContainer", NodeType = BinaryContentTypes.Node)]
		public SlotContainer SlotContainer { get; set; }

		[BinaryContent(Name = "SocketContainer", NodeType = BinaryContentTypes.Node)]
		public SocketContainer SocketContainer { get; set; }

		[BinaryContent(Name = "KamikazeDecal", NodeType = BinaryContentTypes.Attribute)]
		public HexString KamikazeDecal { get; set; }

	}
}
