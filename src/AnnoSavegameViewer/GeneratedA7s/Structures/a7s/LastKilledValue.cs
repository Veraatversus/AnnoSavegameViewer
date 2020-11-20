// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class LastKilledValue {

		[BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
		public LastKilledValuesNoneValue Value { get; set; }

		[BinaryContent(Name = "LastAttack", NodeType = BinaryContentTypes.Attribute)]
		public HexString LastAttack { get; set; }

		[BinaryContent(Name = "SecondLastAttack", NodeType = BinaryContentTypes.Attribute)]
		public HexString SecondLastAttack { get; set; }

	}
}
