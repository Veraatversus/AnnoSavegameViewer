namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class ShipIncident {

		[BinaryContent(Name = "activeType", NodeType = BinaryContentTypes.Node)]
		public ShipIncidentActiveType ActiveType { get; set; }

	}
}
