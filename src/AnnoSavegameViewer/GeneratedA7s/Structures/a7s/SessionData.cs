// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;

	public partial class SessionData {

		[BinaryContent(Name = "BinaryData", NodeType = BinaryContentTypes.Attribute, ConversationType = ConversationTypes.FileDB)]
		public BinaryData BinaryData { get; set; }

	}
}
