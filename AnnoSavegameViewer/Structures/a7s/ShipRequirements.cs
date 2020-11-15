namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class ShipRequirements {

		[BinaryContent(Name = "TransportationType", NodeType = BinaryContentTypes.Node)]
		public TransportationType TransportationType { get; set; }

	}
}
