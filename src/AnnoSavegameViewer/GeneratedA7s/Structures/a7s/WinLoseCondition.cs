// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;

	public partial class WinLoseCondition {

		[BinaryContent(Name = "ElementType", NodeType = BinaryContentTypes.Node)]
		public ElementType ElementType { get; set; }

		[BinaryContent(Name = "Owner", NodeType = BinaryContentTypes.Node)]
		public Owner Owner { get; set; }

	}
}
