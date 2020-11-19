// Copyright � 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class DiscoveryManager {

		[BinaryContent(Name = "GridHeight", NodeType = BinaryContentTypes.Attribute)]
		public Int32 GridHeight { get; set; }

		[BinaryContent(Name = "GridWidth", NodeType = BinaryContentTypes.Attribute)]
		public Int32 GridWidth { get; set; }

		[BinaryContent(Name = "Discovered", NodeType = BinaryContentTypes.Attribute)]
		public HexString Discovered { get; set; }

		[BinaryContent(Name = "DiscoveredIslands", NodeType = BinaryContentTypes.Node)]
		public DiscoveredIslands DiscoveredIslands { get; set; }

		[BinaryContent(Name = "DiscoveryInfos", NodeType = BinaryContentTypes.Node)]
		public DiscoveryInfos DiscoveryInfos { get; set; }

		[BinaryContent(Name = "DiscoveryParticipants", NodeType = BinaryContentTypes.Node)]
		public DiscoveryParticipants DiscoveryParticipants { get; set; }

		[BinaryContent(Name = "DelayedDiscovers", NodeType = BinaryContentTypes.Node)]
		public DelayedDiscovers DelayedDiscovers { get; set; }

		[BinaryContent(Name = "SessionEntered", NodeType = BinaryContentTypes.Node)]
		public SessionEntered SessionEntered { get; set; }

		[BinaryContent(Name = "SharedViews", NodeType = BinaryContentTypes.Node)]
		public SharedViews SharedViews { get; set; }

		[BinaryContent(Name = "FogOfWar", NodeType = BinaryContentTypes.Node)]
		public FogOfWar FogOfWar { get; set; }

		[BinaryContent(Name = "DiscoveryEventObjects", NodeType = BinaryContentTypes.Node)]
		public DiscoveryEventObjects DiscoveryEventObjects { get; set; }

	}
}
