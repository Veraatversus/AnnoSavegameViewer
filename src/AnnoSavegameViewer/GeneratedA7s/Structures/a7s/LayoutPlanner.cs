// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;

	public partial class LayoutPlanner {

		[BinaryContent(Name = "OpenLayout", NodeType = BinaryContentTypes.Node)]
		public OpenLayout OpenLayout { get; set; }

		[BinaryContent(Name = "ProductionLayout", NodeType = BinaryContentTypes.Node)]
		public ProductionLayout ProductionLayout { get; set; }

		[BinaryContent(Name = "CityLayout", NodeType = BinaryContentTypes.Node)]
		public CityLayout CityLayout { get; set; }

		[BinaryContent(Name = "CulturalLayout", NodeType = BinaryContentTypes.Node)]
		public CulturalLayout CulturalLayout { get; set; }

		[BinaryContent(Name = "MiscLayout", NodeType = BinaryContentTypes.Node)]
		public MiscLayout MiscLayout { get; set; }

		[BinaryContent(Name = "HarbourLayout", NodeType = BinaryContentTypes.Node)]
		public HarbourLayout HarbourLayout { get; set; }

	}
}
