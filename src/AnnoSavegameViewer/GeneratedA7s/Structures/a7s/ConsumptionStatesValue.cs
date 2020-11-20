// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using System;

	public partial class ConsumptionStatesValue {

		[BinaryContent(Name = "CurrentSaturation", NodeType = BinaryContentTypes.Attribute)]
		public Single CurrentSaturation { get; set; }

		[BinaryContent(Name = "AverageSaturation", NodeType = BinaryContentTypes.Attribute)]
		public Single AverageSaturation { get; set; }

	}
}
