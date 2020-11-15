namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class AreaIncidentManager {

		[BinaryContent(Name = "incidentTypeData", NodeType = BinaryContentTypes.Node)]
		public IncidentTypeData IncidentTypeData { get; set; }

		[BinaryContent(Name = "militaryTakeoverProgress", NodeType = BinaryContentTypes.Attribute)]
		public HexString MilitaryTakeoverProgress { get; set; }

	}
}
