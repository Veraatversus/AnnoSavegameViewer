// Copyright � 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class MetaRequestsToOutsideValue {

		[BinaryContent(Name = "Product", NodeType = BinaryContentTypes.Attribute)]
		public HexString Product { get; set; }

		[BinaryContent(Name = "Priority", NodeType = BinaryContentTypes.Node)]
		public MetaRequestsToOutsideValuesNonePriority Priority { get; set; }

		[BinaryContent(Name = "Source", NodeType = BinaryContentTypes.Node)]
		public MetaRequestsToOutsideValuesNoneSource Source { get; set; }

	}
}
