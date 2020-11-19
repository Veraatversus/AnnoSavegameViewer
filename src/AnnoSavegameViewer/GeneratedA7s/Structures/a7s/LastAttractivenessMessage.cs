// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System.Collections.Generic;

	public partial class LastAttractivenessMessage : KeyValueDictionary<HexString, LastAttractivenessMessageValue> {

		[BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
		public override List<LastAttractivenessMessageValue> Values { get; set; }

		[BinaryContent(Name = "None", NodeType = BinaryContentTypes.Attribute)]
		public override List<HexString> Keys { get; set; }

	}
}
