// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class SocketContainer {

		[BinaryContent(Name = "SocketItems", NodeType = BinaryContentTypes.Node)]
		public SocketItems SocketItems { get; set; }

		[BinaryContent(Name = "ExternalSocketBuffs", NodeType = BinaryContentTypes.Node)]
		public ExternalSocketBuffs ExternalSocketBuffs { get; set; }

		[BinaryContent(Name = "ActivateEquippedItems", NodeType = BinaryContentTypes.Attribute)]
		public HexString ActivateEquippedItems { get; set; }

		[BinaryContent(Name = "IncidentBuff", NodeType = BinaryContentTypes.Attribute)]
		public DescriptionInt IncidentBuff { get; set; }

	}
}
