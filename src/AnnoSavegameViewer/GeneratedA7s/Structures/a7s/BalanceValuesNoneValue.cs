// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class BalanceValuesNoneValue {

		[BinaryContent(Name = "NetBalance", NodeType = BinaryContentTypes.Attribute)]
		public HexString NetBalance { get; set; }

		[BinaryContent(Name = "ProvidedFor", NodeType = BinaryContentTypes.Node)]
		public ProvidedFor ProvidedFor { get; set; }

		[BinaryContent(Name = "ProvidedBy", NodeType = BinaryContentTypes.Node)]
		public ProvidedBy ProvidedBy { get; set; }

	}
}
