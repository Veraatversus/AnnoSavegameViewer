// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class GroupMemberInformation {

		[BinaryContent(Name = "GroupID", NodeType = BinaryContentTypes.Attribute)]
		public Int16 GroupID { get; set; }

		[BinaryContent(Name = "DesiredOffsetToMid", NodeType = BinaryContentTypes.Attribute)]
		public HexString DesiredOffsetToMid { get; set; }

	}
}
