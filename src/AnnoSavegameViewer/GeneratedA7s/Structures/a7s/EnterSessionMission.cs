// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class EnterSessionMission {

		[BinaryContent(Name = "PendingMission", NodeType = BinaryContentTypes.Attribute)]
		public HexString PendingMission { get; set; }

	}
}
