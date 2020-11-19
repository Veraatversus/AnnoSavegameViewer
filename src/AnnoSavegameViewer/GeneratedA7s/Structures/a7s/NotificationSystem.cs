// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class NotificationSystem {

		[BinaryContent(Name = "LocalPeer", NodeType = BinaryContentTypes.Node)]
		public LocalPeer LocalPeer { get; set; }

		[BinaryContent(Name = "Queue", NodeType = BinaryContentTypes.Node)]
		public Queue Queue { get; set; }

		[BinaryContent(Name = "IDCounter", NodeType = BinaryContentTypes.Attribute)]
		public HexString IDCounter { get; set; }

		[BinaryContent(Name = "Archive", NodeType = BinaryContentTypes.Node)]
		public Archive Archive { get; set; }

		[BinaryContent(Name = "FilterArrays", NodeType = BinaryContentTypes.Node)]
		public FilterArrays FilterArrays { get; set; }

	}
}
