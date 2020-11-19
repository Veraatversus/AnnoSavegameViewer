// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class ItemMapValue {

		[BinaryContent(Name = "ItemID", NodeType = BinaryContentTypes.Attribute)]
		public Int64 ItemID { get; set; }

		[BinaryContent(Name = "GUID", NodeType = BinaryContentTypes.Attribute)]
		public DescriptionInt GUID { get; set; }

		[BinaryContent(Name = "QuestID", NodeType = BinaryContentTypes.Attribute)]
		public Int32 QuestID { get; set; }

		[BinaryContent(Name = "Charges", NodeType = BinaryContentTypes.Attribute)]
		public Int32 Charges { get; set; }

	}
}
