// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;

	public partial class FogOfWarObjectsValue {

		[BinaryContent(Name = "Object", NodeType = BinaryContentTypes.Node)]
		public Object Object { get; set; }

		[BinaryContent(Name = "Participant", NodeType = BinaryContentTypes.Node)]
		public NoneParticipant Participant { get; set; }

		[BinaryContent(Name = "DiscoverRadius", NodeType = BinaryContentTypes.Node)]
		public DiscoverRadius DiscoverRadius { get; set; }

	}
}
