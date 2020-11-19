// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class SequenceData {

		[BinaryContent(Name = "CurrentSequenceID", NodeType = BinaryContentTypes.Attribute)]
		public Int32 CurrentSequenceID { get; set; }

		[BinaryContent(Name = "CurrentSequenceStartTime", NodeType = BinaryContentTypes.Attribute)]
		public TimeSpan CurrentSequenceStartTime { get; set; }

		[BinaryContent(Name = "IdleSequenceID", NodeType = BinaryContentTypes.Attribute)]
		public HexString IdleSequenceID { get; set; }

		[BinaryContent(Name = "Dirty", NodeType = BinaryContentTypes.Attribute)]
		public Boolean Dirty { get; set; }

		[BinaryContent(Name = "CurrentSequenceSpeed", NodeType = BinaryContentTypes.Attribute)]
		public HexString CurrentSequenceSpeed { get; set; }

	}
}
