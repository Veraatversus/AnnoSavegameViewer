// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System.Collections.Generic;

	public partial class DelayedActions : ValuesList<DelayedActionsValue> {

		[BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
		public override List<DelayedActionsValue> Values { get; set; }

	}
}
