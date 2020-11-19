// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class WorkerInfoValue {

		[BinaryContent(Name = "state", NodeType = BinaryContentTypes.Attribute)]
		public Int32 State { get; set; }

		[BinaryContent(Name = "nextTimestamp", NodeType = BinaryContentTypes.Attribute)]
		public TimeSpan NextTimestamp { get; set; }

		[BinaryContent(Name = "positionalData", NodeType = BinaryContentTypes.Attribute)]
		public HexString PositionalData { get; set; }

		[BinaryContent(Name = "forceReturn", NodeType = BinaryContentTypes.Attribute)]
		public Boolean ForceReturn { get; set; }

	}
}
