namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class MetaIncidentManager {

		[BinaryContent(Name = "BonusIncidentChance", NodeType = BinaryContentTypes.Node)]
		public BonusIncidentChance BonusIncidentChance { get; set; }

		[BinaryContent(Name = "IncidentInterval", NodeType = BinaryContentTypes.Node)]
		public IncidentInterval IncidentInterval { get; set; }

	}
}
