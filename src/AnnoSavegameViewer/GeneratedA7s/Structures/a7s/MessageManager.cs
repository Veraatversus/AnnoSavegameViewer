// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;

	public partial class MessageManager {

		[BinaryContent(Name = "NGT", NodeType = BinaryContentTypes.Node)]
		public MessageManagerNGT NGT { get; set; }

		[BinaryContent(Name = "ActionQueue", NodeType = BinaryContentTypes.Node)]
		public MessageManagerActionQueue ActionQueue { get; set; }

	}
}
