// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class AreaIncidentManager {

		[BinaryContent(Name = "incidentTypeData", NodeType = BinaryContentTypes.Node)]
		public IncidentTypeData IncidentTypeData { get; set; }

		[BinaryContent(Name = "militaryTakeoverProgress", NodeType = BinaryContentTypes.Attribute)]
		public HexString MilitaryTakeoverProgress { get; set; }

	}
}
