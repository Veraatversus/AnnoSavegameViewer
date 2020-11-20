// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class FogOfWar {

		[BinaryContent(Name = "IsInitialized", NodeType = BinaryContentTypes.Attribute)]
		public Boolean IsInitialized { get; set; }

		[BinaryContent(Name = "DiscoverRadius", NodeType = BinaryContentTypes.Attribute)]
		public Single DiscoverRadius { get; set; }

		[BinaryContent(Name = "FOWGrid", NodeType = BinaryContentTypes.Node)]
		public FOWGrid FOWGrid { get; set; }

		[BinaryContent(Name = "FOWArea", NodeType = BinaryContentTypes.Attribute)]
		public HexString FOWArea { get; set; }

		[BinaryContent(Name = "Objects", NodeType = BinaryContentTypes.Node)]
		public FogOfWarObjects Objects { get; set; }

		[BinaryContent(Name = "FogsOfWar", NodeType = BinaryContentTypes.Node)]
		public FogsOfWar FogsOfWar { get; set; }

		[BinaryContent(Name = "FowIsland", NodeType = BinaryContentTypes.Attribute)]
		public HexString FowIsland { get; set; }

	}
}
