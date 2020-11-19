// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using System;

	public partial class LoadingPier {

		[BinaryContent(Name = "LoadingHarbourID", NodeType = BinaryContentTypes.Attribute)]
		public Int64 LoadingHarbourID { get; set; }

		[BinaryContent(Name = "CurrentTradePartnerArray", NodeType = BinaryContentTypes.Node)]
		public CurrentTradePartnerArray CurrentTradePartnerArray { get; set; }

	}
}
