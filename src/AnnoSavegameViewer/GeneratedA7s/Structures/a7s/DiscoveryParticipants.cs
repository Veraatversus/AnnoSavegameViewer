// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System.Collections.Generic;

	public partial class DiscoveryParticipants : ValuesList<DiscoveryParticipantsValue> {

		[BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
		public override List<DiscoveryParticipantsValue> Values { get; set; }

	}
}
