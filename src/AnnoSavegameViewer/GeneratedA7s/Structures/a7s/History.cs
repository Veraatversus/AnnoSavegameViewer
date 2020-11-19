// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class History {

		[BinaryContent(Name = "globalHistory", NodeType = BinaryContentTypes.Node)]
		public GlobalHistory GlobalHistory { get; set; }

		[BinaryContent(Name = "areaHistory", NodeType = BinaryContentTypes.Node)]
		public AreaHistory AreaHistory { get; set; }

		[BinaryContent(Name = "lastSnapshot", NodeType = BinaryContentTypes.Attribute)]
		public HexString LastSnapshot { get; set; }

	}
}
