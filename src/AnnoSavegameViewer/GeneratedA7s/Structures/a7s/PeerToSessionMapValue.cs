// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class PeerToSessionMapValue {

		[BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
		public NoneValue Value { get; set; }

		[BinaryContent(Name = "LastActiveSession", NodeType = BinaryContentTypes.Attribute)]
		public DescriptionInt LastActiveSession { get; set; }

		[BinaryContent(Name = "CurrentlyActiveSession", NodeType = BinaryContentTypes.Attribute)]
		public DescriptionInt CurrentlyActiveSession { get; set; }

	}
}
