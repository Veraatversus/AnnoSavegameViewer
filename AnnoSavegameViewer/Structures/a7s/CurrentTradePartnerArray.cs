namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;
	using System.Collections.Generic;

	public partial class CurrentTradePartnerArray : ValuesList<CurrentTradePartnerArrayValue> {

		[BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
		public override List<CurrentTradePartnerArrayValue> Values { get; set; }

	}
}
