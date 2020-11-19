// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using System;

	public partial class FreeAreaproductivity {

		[BinaryContent(Name = "WorkerInfo", NodeType = BinaryContentTypes.Node)]
		public WorkerInfo WorkerInfo { get; set; }

		[BinaryContent(Name = "InitializeForestTime", NodeType = BinaryContentTypes.Attribute)]
		public TimeSpan InitializeForestTime { get; set; }

	}
}
