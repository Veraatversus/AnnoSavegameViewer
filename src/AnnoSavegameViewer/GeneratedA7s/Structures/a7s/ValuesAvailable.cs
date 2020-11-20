// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class ValuesAvailable {

		[BinaryContent(Name = "ParticipantType", NodeType = BinaryContentTypes.Node)]
		public AvailableParticipantType ParticipantType { get; set; }

		[BinaryContent(Name = "Team", NodeType = BinaryContentTypes.Node)]
		public AvailableTeam Team { get; set; }

		[BinaryContent(Name = "Coop", NodeType = BinaryContentTypes.Attribute)]
		public HexString Coop { get; set; }

		[BinaryContent(Name = "CompanyColor", NodeType = BinaryContentTypes.Node)]
		public AvailableCompanyColor CompanyColor { get; set; }

		[BinaryContent(Name = "PlayerPossessions", NodeType = BinaryContentTypes.Attribute)]
		public HexString PlayerPossessions { get; set; }

	}
}
