// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;

	public partial class MetaIncidentManager {

		[BinaryContent(Name = "BonusIncidentChance", NodeType = BinaryContentTypes.Node)]
		public BonusIncidentChance BonusIncidentChance { get; set; }

		[BinaryContent(Name = "IncidentInterval", NodeType = BinaryContentTypes.Node)]
		public IncidentInterval IncidentInterval { get; set; }

	}
}
