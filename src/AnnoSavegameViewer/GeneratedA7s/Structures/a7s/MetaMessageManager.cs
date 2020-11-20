// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;

	public partial class MetaMessageManager {

		[BinaryContent(Name = "NGT", NodeType = BinaryContentTypes.Node)]
		public NGT NGT { get; set; }

		[BinaryContent(Name = "ActionQueue", NodeType = BinaryContentTypes.Node)]
		public ActionQueue ActionQueue { get; set; }

	}
}
