// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;

	public partial class ConstructionBarSettingsValue {

		[BinaryContent(Name = "PinConfigLeft", NodeType = BinaryContentTypes.Node)]
		public PinConfigLeft PinConfigLeft { get; set; }

		[BinaryContent(Name = "PinConfigRight", NodeType = BinaryContentTypes.Node)]
		public PinConfigRight PinConfigRight { get; set; }

	}
}
