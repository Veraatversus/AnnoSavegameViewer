// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class ProcessingTransportersValue {

		[BinaryContent(Name = "Transporter", NodeType = BinaryContentTypes.Node)]
		public NoneTransporter Transporter { get; set; }

		[BinaryContent(Name = "ProcessingTime", NodeType = BinaryContentTypes.Attribute)]
		public HexString ProcessingTime { get; set; }

		[BinaryContent(Name = "ProcessingEndTime", NodeType = BinaryContentTypes.Attribute)]
		public HexString ProcessingEndTime { get; set; }

	}
}
