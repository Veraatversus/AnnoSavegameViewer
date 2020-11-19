// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class IncidentResolver {

		[BinaryContent(Name = "resolverUnits", NodeType = BinaryContentTypes.Node)]
		public ResolverUnits ResolverUnits { get; set; }

		[BinaryContent(Name = "specialUnits", NodeType = BinaryContentTypes.Node)]
		public SpecialUnits SpecialUnits { get; set; }

		[BinaryContent(Name = "specialActionCooldown", NodeType = BinaryContentTypes.Attribute)]
		public HexString SpecialActionCooldown { get; set; }

	}
}
