// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using System;

	public partial class GrowingMapValue {

		[BinaryContent(Name = "growingStart", NodeType = BinaryContentTypes.Attribute)]
		public TimeSpan GrowingStart { get; set; }

		[BinaryContent(Name = "growingDuration", NodeType = BinaryContentTypes.Attribute)]
		public TimeSpan GrowingDuration { get; set; }

		[BinaryContent(Name = "growingSize", NodeType = BinaryContentTypes.Attribute)]
		public Single GrowingSize { get; set; }

	}
}
