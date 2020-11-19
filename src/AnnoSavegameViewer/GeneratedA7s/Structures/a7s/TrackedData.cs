// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System.Collections.Generic;

	public partial class TrackedData : KeysList<HexString> {

		[BinaryContent(Name = "LowTracked", NodeType = BinaryContentTypes.Attribute)]
		public HexString LowTracked { get; set; }

		[BinaryContent(Name = "HighTracked", NodeType = BinaryContentTypes.Attribute)]
		public HexString HighTracked { get; set; }

		[BinaryContent(Name = "None", NodeType = BinaryContentTypes.Attribute)]
		public override List<HexString> Keys { get; set; }

	}
}
