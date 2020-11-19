// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;
	using System.Collections.Generic;

	public partial class LoadingPiers : ValuesList<LoadingPiersValue> {

		[BinaryContent(Name = "size", NodeType = BinaryContentTypes.Attribute)]
		public Int32 Size { get; set; }

		[BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
		public override List<LoadingPiersValue> Values { get; set; }

	}
}
