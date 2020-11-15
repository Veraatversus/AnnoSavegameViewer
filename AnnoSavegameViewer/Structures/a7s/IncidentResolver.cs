namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class IncidentResolver {

		[BinaryContent(Name = "resolverUnits", NodeType = BinaryContentTypes.Node)]
		public ResolverUnits ResolverUnits { get; set; }

		[BinaryContent(Name = "specialUnits", NodeType = BinaryContentTypes.Node)]
		public SpecialUnits SpecialUnits { get; set; }

		[BinaryContent(Name = "specialActionCooldown", NodeType = BinaryContentTypes.Attribute)]
		public HexString SpecialActionCooldown { get; set; }

	}
}
