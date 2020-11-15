namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class AreaTransporterManager {

		[BinaryContent(Name = "Transporters", NodeType = BinaryContentTypes.Node)]
		public AreaTransporterManagerTransporters Transporters { get; set; }

		[BinaryContent(Name = "UnsentTransporters", NodeType = BinaryContentTypes.Node)]
		public UnsentTransporters UnsentTransporters { get; set; }

	}
}
