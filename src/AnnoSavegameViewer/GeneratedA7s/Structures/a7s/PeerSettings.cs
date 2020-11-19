// Copyright � 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using System;

	public partial class PeerSettings {

		[BinaryContent(Name = "RightClickMenuSettings", NodeType = BinaryContentTypes.Node)]
		public RightClickMenuSettings RightClickMenuSettings { get; set; }

		[BinaryContent(Name = "ConstructionBarSettings", NodeType = BinaryContentTypes.Node)]
		public ConstructionBarSettings ConstructionBarSettings { get; set; }

		[BinaryContent(Name = "MinimapFilter", NodeType = BinaryContentTypes.Node)]
		public MinimapFilter MinimapFilter { get; set; }

		[BinaryContent(Name = "FirstWelcomeMessageAvailable", NodeType = BinaryContentTypes.Node)]
		public FirstWelcomeMessageAvailable FirstWelcomeMessageAvailable { get; set; }

		[BinaryContent(Name = "ConstructionMenuMode", NodeType = BinaryContentTypes.Node)]
		public ConstructionMenuMode ConstructionMenuMode { get; set; }

		[BinaryContent(Name = "StraticMapBlacklist", NodeType = BinaryContentTypes.Node)]
		public StraticMapBlacklist StraticMapBlacklist { get; set; }

		[BinaryContent(Name = "MinimapZoom", NodeType = BinaryContentTypes.Attribute)]
		public Int32 MinimapZoom { get; set; }

	}
}
