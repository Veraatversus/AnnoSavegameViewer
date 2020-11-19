// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System.Collections.Generic;

	public partial class BuyingMoney : KeysList<DescriptionInt> {

		[BinaryContent(Name = "None", NodeType = BinaryContentTypes.Attribute)]
		public override List<DescriptionInt> Keys { get; set; }

	}
}
